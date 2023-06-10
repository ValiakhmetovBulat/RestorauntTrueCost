using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class TableOrderRepository : BaseRepository<TableOrder>, ITableOrderRepository
    {
        public TableOrderRepository(RestorauntDbContext context) : base(context) { }
    }
}
