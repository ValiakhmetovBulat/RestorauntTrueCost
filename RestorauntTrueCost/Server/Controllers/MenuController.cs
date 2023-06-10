using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;
using RestorauntTrueCost.Shared.Models;

namespace RestorauntTrueCost.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        IMenuPositionsRepository _db;
        IWebHostEnvironment _env;

        public MenuController(IMenuPositionsRepository db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        /// <summary>
        /// Gets all the menu positions
        /// </summary>
        /// <returns></returns> 
        [HttpGet]
        public async Task<IEnumerable<MenuPosition>> Get() => await _db.GetAll();

        [HttpGet("getimage/{positionId}")]
        public async Task<IActionResult> GetPositionImage(int positionId)
        {
            var foundPosition = await _db.GetById(positionId);

            if (foundPosition == null)
            {
                return NotFound("Позиция меню не найдена");
            }
            if (foundPosition.Photo == null)
            {
                return BadRequest("У данной позици нет загруженного изображения");
            }
            var fileName = foundPosition.Photo;

            var filePath = Path.Combine(_env.WebRootPath, fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            var contentType = GetContentType(fileName);

            return File(fileBytes, contentType, fileName);
        }

        private string GetContentType(string fileName)
        {
            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(fileName, out var contentType))
            {
                contentType = "application/octet-stream";

                if (fileName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    fileName.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                {
                    contentType = "image/jpeg";
                }
                else if (fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                {
                    contentType = "image/png";
                }
            }
            return contentType;
        }


        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<ActionResult<MenuPosition>> CreateMenuPosition([FromBody] MenuPositionDto model)
        {
            var menuPosition = model.menuPosition;

            if (_db.Find(u => u.Name == menuPosition.Name).Result.FirstOrDefault() != null)
            {
                return BadRequest("Позиция меню с данным именем уже существует");
            }

            if (model.FileData != null)
            {
                var fileName = Path.GetRandomFileName();
                var filePath = Path.Combine(_env.WebRootPath, fileName);
                filePath = Path.ChangeExtension(filePath, "png");
                await System.IO.File.WriteAllBytesAsync(filePath, model.FileData);
                menuPosition.Photo = filePath;
            }

            var lastId = _db.GetAll().Result.Max(u => u.Id) + 1;
            menuPosition.Id = lastId;

            await _db.Create(menuPosition);
            return Ok(menuPosition);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{menuPositionId}")]
        public async Task<ActionResult<MenuPosition>> DeleteMenuPosition(int menuPositionId)
        {
            var positionType = await _db.GetById(menuPositionId);
            if (positionType != null)
            {
                if (positionType.Photo != null)
                {
                    var positionImagePath = Path.Combine(_env.WebRootPath, positionType.Photo);

                    if (System.IO.File.Exists(positionImagePath))
                    {
                        System.IO.File.Delete(positionImagePath);
                    }
                }
                await _db.Delete(positionType);
                return Ok(positionType);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("getbyid/{menuPositionId}")]
        public async Task<ActionResult<MenuPosition>> GetMenuPositionById(int menuPositionId)
        {
            var menuPosition = await _db.GetById(menuPositionId);

            if (menuPosition != null)
            {
                return Ok(menuPosition);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("update/{menuPositionId}")]
        public async Task<ActionResult<MenuPosition>> UpdateMenuPosition(int menuPositionId, [FromBody] MenuPositionDto menuPositionModel)
        {
            var foundMenuPosition = await _db.GetById(menuPositionId);

            if (foundMenuPosition != null)
            {
                var menuPosition = menuPositionModel.menuPosition;
                var menuImage = menuPositionModel.FileData;

                var existingMenuPositionWithName = _db.Find(p => p.Name == menuPosition.Name).Result.FirstOrDefault();

                if (existingMenuPositionWithName != null && existingMenuPositionWithName.Id != menuPosition.Id)
                {
                    return BadRequest("Позиция меню с данным именем уже существует в системе");
                }

                foundMenuPosition.Name = menuPosition.Name;
                foundMenuPosition.Price = menuPosition.Price;
                foundMenuPosition.PositionTypeId = menuPosition.PositionTypeId;
                foundMenuPosition.Decription = menuPosition.Decription;

                if (menuImage != null)
                {
                    if (menuPosition.Photo != null)
                    {
                        var positionImagePath = Path.Combine(_env.WebRootPath, menuPosition.Photo);

                        if (System.IO.File.Exists(positionImagePath))
                        {
                            System.IO.File.Delete(positionImagePath);
                        }
                    }

                    var fileName = Path.GetRandomFileName();
                    var filePath = Path.Combine(_env.WebRootPath, fileName);
                    filePath = Path.ChangeExtension(filePath, "png");
                    await System.IO.File.WriteAllBytesAsync(filePath, menuImage);
                    foundMenuPosition.Photo = filePath;
                }

                try
                {
                    await _db.Update(foundMenuPosition);
                    return Ok(foundMenuPosition);
                }
                catch (Exception)
                {
                    return BadRequest("Произошла ошибка при выполнении запроса.");
                }

            }
            return BadRequest("Позиция меню не найдена");
        }
    }
}