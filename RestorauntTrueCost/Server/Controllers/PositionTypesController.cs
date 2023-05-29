using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Shared.Entities;

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
    }
}
