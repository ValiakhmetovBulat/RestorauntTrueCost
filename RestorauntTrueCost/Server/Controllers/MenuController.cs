using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Data;

namespace RestorauntTrueCost.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        IMenuPositionsRepository _db;
        
        public MenuController(IMenuPositionsRepository db)
        {
            _db = db;
        }
        IWebHostEnvironment _webHostEnvironment;
        /// <summary>
        /// Gets all the menu positions
        /// </summary>
        /// <returns></returns> 
        [HttpGet]
        public async Task<IEnumerable<MenuPosition>> Get() => await _db.GetAll();

        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<ActionResult<MenuPosition>> CreateMenuPosition(MenuPosition menuPosition)
        {
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