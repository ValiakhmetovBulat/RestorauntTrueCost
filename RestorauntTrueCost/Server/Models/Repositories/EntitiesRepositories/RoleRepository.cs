using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntApi.Models.EntititesRepositories.Entities
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(RestorauntDbContext context) : base(context) { }
    }
}
