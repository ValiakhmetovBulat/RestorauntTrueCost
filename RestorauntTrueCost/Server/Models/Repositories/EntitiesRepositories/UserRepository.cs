using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntApi.Models.EntititesRepositories.Entities
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(RestorauntDbContext context) : base(context) { }
    }
}

