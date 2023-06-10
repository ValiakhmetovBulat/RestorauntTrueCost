using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(RestorauntDbContext context) : base(context) { }
    }
}

