﻿using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderPeriodController : ControllerBase
    {
        IOrderPeriodRepository _db;

        public OrderPeriodController(IOrderPeriodRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderPeriod>> Get() => await _db.GetAll();
    }
}
