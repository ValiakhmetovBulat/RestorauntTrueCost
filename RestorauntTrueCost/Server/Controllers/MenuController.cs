using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;
using RestorauntTrueCost.Shared.Models;
using System.Data;

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

        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<ActionResult<MenuPosition>> CreateMenuPosition([FromBody] MenuPositionDto model)
        {
            var menuPosition = model.menuPosition;
            var image = model.formFile;

            if (image != null)
            {
                var rootPath = _env.WebRootPath;
                var contentPath = _env.ContentRootPath;

                var totalPath = Path.Combine(rootPath, "images", "positions");

                Directory.CreateDirectory(totalPath);

                var fileName = Path.GetRandomFileName();

                using (FileStream stream = new FileStream(Path.Combine(totalPath, fileName), FileMode.Create))
                {
                    await image.OpenReadStream().CopyToAsync(stream);
                    menuPosition.Photo = fileName;
                }
            }           

            if (_db.Find(u => u.Name == menuPosition.Name).Result.FirstOrDefault() != null)
            {
                return BadRequest("ѕозици€ меню с данным именем уже существует");
            }

            var lastId = _db.GetAll().Result.Max(u => u.Id) + 1;
            menuPosition.Id = lastId;

            await _db.Create(menuPosition);
            return Ok(menuPosition);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{menuPositionId}")]
        public async Task<ActionResult<MenuPosition>> DeleteSection(int menuPositionId)
        {
            var positionType = await _db.GetById(menuPositionId);
            if (positionType != null)
            {
                await _db.Delete(positionType);
                return Ok(positionType);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("getbyid/{menuPositionId}")]
        public async Task<ActionResult<PositionType>> GetMenuPositionById(int menuPositionId)
        {
            var menuPosition = await _db.GetById(menuPositionId);

            if (menuPosition != null)
            {
                return Ok(menuPosition);
            }

            return NotFound();
        }
    }
}