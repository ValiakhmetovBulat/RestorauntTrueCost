using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class CartToPositionRepository : BaseRepository<CartToPosition>, ICartToPositionRepository
    {
        public CartToPositionRepository(RestorauntDbContext context) : base(context) { }
    }
}
