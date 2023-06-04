using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;
using RestorauntTrueCost.Shared.Models;
using System.Data;
using System.Net;

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
            var files = model.files;

            if (files != null)
            {
                if (files.Count() > 0)
                {
                    
                    foreach (var file in files)
                    {
                        string trustedFileName;
                        var fileName = file.FileName;
                        try
                        {
                            trustedFileName = Path.GetRandomFileName();

                            var path = Path.Combine(_env.ContentRootPath,
                                _env.EnvironmentName, "uploads",
                                trustedFileName);

                            await using FileStream fs = new(path, FileMode.Create);
                            await file.CopyToAsync(fs);
                        }
                        catch (Exception)
                        {
                            return BadRequest("bad file");
                        }
                    }
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

        [HttpPost("filesave")]
        public async Task<ActionResult<IList<UploadResult>>> PostFile(
        [FromForm] IEnumerable<IFormFile> files)
        {
            var maxAllowedFiles = 3;
            long maxFileSize = 1024 * 15 * 1024;
            var filesProcessed = 0;
            var resourcePath = new Uri($"{Request.Scheme}://{Request.Host}/");
            List<UploadResult> uploadResults = new();

            foreach (var file in files)
            {
                var uploadResult = new UploadResult();
                string trustedFileNameForFileStorage;
                var untrustedFileName = file.FileName;
                uploadResult.FileName = untrustedFileName;
                var trustedFileNameForDisplay =
                    WebUtility.HtmlEncode(untrustedFileName);

                if (filesProcessed < maxAllowedFiles)
                {
                    if (file.Length == 0)
                    {
                        uploadResult.ErrorCode = 1;
                    }
                    else if (file.Length > maxFileSize)
                    {
                        uploadResult.ErrorCode = 2;
                    }
                    else
                    {
                        try
                        {
                            trustedFileNameForFileStorage = Path.GetRandomFileName();
                            var path = Path.Combine(_env.ContentRootPath,
                                trustedFileNameForFileStorage);

                            await using FileStream fs = new(path, FileMode.Create);
                            await file.CopyToAsync(fs);

                            uploadResult.Uploaded = true;
                            uploadResult.StoredFileName = trustedFileNameForFileStorage;
                        }
                        catch (IOException ex)
                        {
                            uploadResult.ErrorCode = 3;
                        }
                    }

                    filesProcessed++;
                }
                else
                {
                    uploadResult.ErrorCode = 4;
                }

                uploadResults.Add(uploadResult);
            }

            return new CreatedResult(resourcePath, uploadResults);
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