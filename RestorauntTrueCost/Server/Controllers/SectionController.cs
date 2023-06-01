using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Data;

namespace RestorauntTrueCost.Server.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class SectionController : ControllerBase
    {
        ISectionsRepository _db;

        public SectionController(ISectionsRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<Section>> Get() => await _db.GetAll();

        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<ActionResult<Section>> CreateSection(Section section)
        {
            if (_db.Find(u => u.Name == section.Name || u.NameRU == section.NameRU).Result.FirstOrDefault() != null)
            {
                return BadRequest("Секция с данным именем уже существует");
            }

            var lastId = _db.GetAll().Result.Max(u => u.Id) + 1;
            section.Id = lastId;

            await _db.Create(section);
            return Ok(section);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("getbyid/{sectionId}")]
        public async Task<ActionResult<Section>> GetSectionById(int sectionId)
        {
            var section = await _db.GetById(sectionId);

            if (section != null)
            {
                return Ok(section);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{sectionId}")]
        public async Task<ActionResult<Section>> DeleteSection(int sectionId)
        {
            var section = await _db.GetById(sectionId);
            if (section != null)
            {
                await _db.Delete(section);
                return Ok(section);
            }

            return NotFound();
        }

    }
}
