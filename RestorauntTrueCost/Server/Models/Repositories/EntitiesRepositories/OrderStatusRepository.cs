using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class OrderStatusRepository : BaseRepository<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(RestorauntDbContext context) : base(context) { }
    }
}
