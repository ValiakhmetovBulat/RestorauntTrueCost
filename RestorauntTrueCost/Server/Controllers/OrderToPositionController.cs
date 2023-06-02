using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderToPositionController : ControllerBase
    {
        IOrderToPositionRepository _db;

        public OrderToPositionController(IOrderToPositionRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderToPosition>> Get() => await _db.GetAll();

        [Authorize]
        [HttpPost("create")]
        public async Task<ActionResult<IEnumerable<OrderToPosition>>> CreateTableOrders(List<OrderToPosition> ordersToPosition)
        {
            if (ordersToPosition == null || ordersToPosition.Count == 0)
            {
                return BadRequest("List was empty");
            }
            await _db.AddRange(ordersToPosition);
            return Ok(ordersToPosition);
        }
    }
}
