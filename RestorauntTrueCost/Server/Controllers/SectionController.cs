using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
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
    }
}
