using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
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
