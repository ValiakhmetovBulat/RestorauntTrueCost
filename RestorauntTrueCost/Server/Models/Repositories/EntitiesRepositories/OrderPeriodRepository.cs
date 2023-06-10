using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class OrderPeriodRepository : BaseRepository<OrderPeriod>, IOrderPeriodRepository
    {
        public OrderPeriodRepository(RestorauntDbContext context) : base(context) { }
    }
}
