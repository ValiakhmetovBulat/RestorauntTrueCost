using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        ITableRepository _db;

        public TableController(ITableRepository db)
        {
            _db = db;
        }

        [HttpGet("tablebynum/{tableNumber}")]
        public async Task<ActionResult<Table>> GetTableByNumber(int tableNumber)
        {
            var table = _db.Find(t => t.TableNum == tableNumber).Result.FirstOrDefault();

            if (table == null)
            {
                return NotFound();
            }
            return await Task.FromResult(table);
        }
    }
}
