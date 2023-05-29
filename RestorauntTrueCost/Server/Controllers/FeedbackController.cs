using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        IReviewRepository _db;

        public FeedbackController(IReviewRepository db)
        {
            _db = db;
        }

        [Authorize]
        [HttpPost("leavefeedback")]
        public async Task<Review> LeaveFeedback(Review review)
        {
            review.IsAccepted = false;
            return await _db.Create(review);
        }
    }
}
