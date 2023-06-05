using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;
using RestorauntTrueCost.Shared.Models;
using System.Data;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionTypesController : ControllerBase
    {
        IPositionTypesRepository _db;

        public PositionTypesController(IPositionTypesRepository context)
        {
            _db = context;
        }

        /// <summary>
        /// Gets all the position types
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        public async Task<IEnumerable<PositionType>> Get() => await _db.GetAll();

        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<ActionResult<PositionType>> CreatePositionType(PositionType positionType)
        {
            if (_db.Find(u => u.Name == positionType.Name || u.NameRu == positionType.NameRu).Result.FirstOrDefault() != null)
            {
                return BadRequest("Тип секции с данным именем уже существует");
            }

            var lastId = _db.GetAll().Result.Max(u => u.Id) + 1;
            positionType.Id = lastId;

            await _db.Create(positionType);
            return Ok(positionType);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{positionTypeId}")]
        public async Task<ActionResult<PositionType>> DeletePositionType(int positionTypeId)
        {
            var positionType = await _db.GetById(positionTypeId);
            if (positionType != null)
            {
                await _db.Delete(positionType);
                return Ok(positionType);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("getbyid/{positionTypeId}")]
        public async Task<ActionResult<PositionType>> GetPositionTypeById(int positionTypeId)
        {
            var positionType = await _db.GetById(positionTypeId);

            if (positionType != null)
            {
                return Ok(positionType);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("update/{positionTypeId}")]
        public async Task<ActionResult<PositionType>> UpdatePositionType(int positionTypeId, [FromBody] PositionType positionType)
        {
            var foundPositionType = await _db.GetById(positionTypeId);

            if (foundPositionType != null)
            {
                var existingTypeWithName = _db.Find(p => p.Name == positionType.Name).Result.FirstOrDefault();

                if (existingTypeWithName != null && existingTypeWithName.Id != positionType.Id)
                {
                    return BadRequest("Тип секции с данным именем (английский) уже существует в системе");
                }

                var existingTypeWithNameRu = _db.Find(p => p.NameRu == positionType.NameRu).Result.FirstOrDefault();
                if (existingTypeWithNameRu != null && existingTypeWithNameRu.Id != positionType.Id)
                {
                    return BadRequest("Тип секции с данным именем (русский) уже существует в системе");
                }

                foundPositionType.NameRu = positionType.NameRu;
                foundPositionType.Name = positionType.Name;

                foundPositionType.SectionId = positionType.SectionId;

                try
                {
                    await _db.Update(foundPositionType);
                    return Ok(foundPositionType);
                }
                catch (Exception)
                {
                    return BadRequest("Произошла ошибка при выполнении запроса.");
                }

            }
            return BadRequest("Тип секции меню не найден");
        }
    }
}
