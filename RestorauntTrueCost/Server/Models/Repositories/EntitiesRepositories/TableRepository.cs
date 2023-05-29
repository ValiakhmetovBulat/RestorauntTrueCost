using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class TableRepository : BaseRepository<Table>, ITableRepository
    {
        public TableRepository(RestorauntDbContext context) : base(context) { }
    }
}
