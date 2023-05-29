using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Shared.Entities;

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

        /// <summary>
        /// Gets all the menu positions
        /// </summary>
        /// <returns></returns> 
        [HttpGet]
        public async Task<IEnumerable<MenuPosition>> Get() => await _db.GetAll();
    }
}