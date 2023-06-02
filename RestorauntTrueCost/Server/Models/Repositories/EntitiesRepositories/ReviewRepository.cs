using RestorauntTrueCost.Server.Models.DatabaseContext;
using RestorauntTrueCost.Server.Models.Repositories;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.Repositories.EntitiesRepositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(RestorauntDbContext context) : base(context) { }
    }
}
