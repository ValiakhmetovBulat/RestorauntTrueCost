using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        IOrderStatusRepository _db;

        public OrderStatusController(IOrderStatusRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderStatus>> Get() => await _db.GetAll();

    }
}
