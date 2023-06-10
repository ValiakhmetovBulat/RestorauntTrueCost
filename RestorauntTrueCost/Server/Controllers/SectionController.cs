using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

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
                try
                {
                    await _db.Delete(section);
                    return Ok(section);
                }
                catch (Exception)
                {
                    return BadRequest("Чтобы удалить секцию меню сначала необходимо удалить все типы секции");
                }
            }

            return NotFound();
        }


        [Authorize(Roles = "Admin")]
        [HttpPut("update/{sectionId}")]
        public async Task<ActionResult<Section>> UpdateSection(int sectionId, [FromBody] Section section)
        {
            var foundSection = await _db.GetById(sectionId);

            if (foundSection != null)
            {
                var existingSectionWithName = _db.Find(p => p.Name == section.Name).Result.FirstOrDefault();

                if (existingSectionWithName != null && existingSectionWithName.Id != section.Id)
                {
                    return BadRequest("Секция с данным именем (английский) уже существует в системе");
                }

                var existingSectionWithNameRu = _db.Find(p => p.NameRU == section.NameRU).Result.FirstOrDefault();
                if (existingSectionWithNameRu != null && existingSectionWithNameRu.Id != section.Id)
                {
                    return BadRequest("Секция с данным именем (русский) уже существует в системе");
                }

                foundSection.NameRU = section.NameRU;
                foundSection.Name = section.Name;

                try
                {
                    await _db.Update(foundSection);
                    return Ok(foundSection);
                }
                catch (Exception)
                {
                    return BadRequest("Произошла ошибка при выполнении запроса.");
                }

            }
            return BadRequest("Секция меню не найдена");
        }
    }
}
