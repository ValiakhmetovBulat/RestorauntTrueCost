using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class SectionsRepository : BaseRepository<Section>, ISectionsRepository
    {
        public SectionsRepository(RestorauntDbContext context) : base(context) { }
    }
}
