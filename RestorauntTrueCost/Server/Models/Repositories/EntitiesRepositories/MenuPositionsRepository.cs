using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class MenuPositionsRepository : BaseRepository<MenuPosition>, IMenuPositionsRepository
    {
        public MenuPositionsRepository(RestorauntDbContext context) : base(context) { }
    }
}
