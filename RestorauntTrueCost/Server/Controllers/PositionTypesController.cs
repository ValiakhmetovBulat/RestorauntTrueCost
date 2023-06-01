using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Shared.Entities;
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
        public async Task<ActionResult<PositionType>> DeleteSection(int positionTypeId)
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
    }
}
