using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class PositionTypesRepository : BaseRepository<PositionType>, IPositionTypesRepository
    {
        public PositionTypesRepository(RestorauntDbContext context) : base(context) { }
    }
}
