using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Models;
using System.Security.Claims;
using Order = RestorauntTrueCost.Shared.Entities.Order;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderRepository _db;

        public OrderController(IOrderRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<Order>> Get() => await _db.GetAll();

        [Authorize]
        [HttpGet("myorders")]
        public async Task<ActionResult<Order>> GetUserOrders()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                if (Int32.TryParse(userId, out int id))
                {
                    var orders = await _db.Find(c => c.UserId == id);

                    return Ok(orders);
                }
                else
                {
                    return BadRequest("Invalid UserId");
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<Order>> GetOrderById(int orderId)
        {
            var order = await _db.GetById(orderId);
            if (order != null)
            {
                return Ok(order);
            }
            return NotFound();
        }

        [Authorize(Roles = "Manager,Admin")]
        [HttpPut("changeorderstatus/{orderId}")]
        public async Task<ActionResult<Order>> ChangeOrderStatus(int orderId, [FromBody] OrderStatusDto orderStatus)
        {
            var found = await _db.GetById(orderId);
            if (found != null)
            {
                found.OrderStatusId = orderStatus.OrderStatusId;
                await _db.Update(found);
                return Ok(found);
            }
            return BadRequest("Order not found");
        }

        [Authorize]
        [HttpPost("createorder")]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                if (Int32.TryParse(userId, out int id))
                {
                    order.UserId = id;
                    await _db.Create(order);
                    return Ok(order);
                }
                else
                {
                    return BadRequest("Invalid UserId");
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        [Authorize]
        [HttpPut("update")]
        public async Task<ActionResult<Order>> UpdateOrder([FromBody] Order order)
        {
            if (User.FindFirstValue(ClaimTypes.NameIdentifier) == order.UserId.ToString())
            {
                await _db.Update(order);
                return await Task.FromResult(order);
            }
            else
            {
                return Forbid();
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{orderId}")]
        public async Task<ActionResult<Order>> DeleteOrder(int orderId)
        {
            var order = await _db.GetById(orderId);
            if (order != null)
            {
                await _db.Delete(order);
                return Ok(order);
            }

            return NotFound();
        }
    }
}
