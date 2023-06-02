using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Security.Claims;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableOrderController : ControllerBase
    {
        ITableOrderRepository _db;

        public TableOrderController(ITableOrderRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<TableOrder>> Get() => await _db.GetAll();

        [Authorize]
        [HttpPost("create")]
        public async Task<ActionResult<IEnumerable<TableOrder>>> CreateTableOrders(List<TableOrder> tableOrders)
        {
            if (tableOrders == null || tableOrders.Count == 0)
            {
                return BadRequest("List was empty");
            }
            await _db.AddRange(tableOrders);
            return Ok(tableOrders);
        }
    }
}
