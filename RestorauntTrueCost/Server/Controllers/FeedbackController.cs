using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorauntTrueCost.Server.Models.Repositories.EntitiesInterfaces;
using RestorauntTrueCost.Shared.Entities;
using RestorauntTrueCost.Shared.Models;

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

        [Authorize(Roles = "Admin,Manager")]
        [HttpGet("admin")]
        public async Task<IEnumerable<Review>> Get() => await _db.GetAll();

        [HttpGet]
        public async Task<IEnumerable<Review>> GetAll()
        {
            var reviewList = await _db.GetAll();
            reviewList = reviewList.Where(r => r.IsAccepted == true).ToList();
            return reviewList;
        }

        [Authorize(Roles = "Admin,Manager")]
        [HttpDelete("delete/{reviewId}")]
        public async Task<ActionResult<User>> DeleteReview(int reviewId)
        {
            var review = await _db.GetById(reviewId);
            if (review != null)
            {
                await _db.Delete(review);
                return Ok(review);
            }

            return NotFound();
        }


        [Authorize]
        [HttpPost("leavefeedback")]
        public async Task<Review> LeaveFeedback(Review review)
        {
            review.IsAccepted = false;
            return await _db.Create(review);
        }

        [Authorize(Roles = "Manager,Admin")]
        [HttpPut("acceptreview/{reviewId}")]
        public async Task<ActionResult<Review>> AcceptReview(int reviewId, [FromBody] ReviewAcceptionDto reviewAcception)
        {
            var found = await _db.GetById(reviewId);
            if (found != null)
            {
                found.IsAccepted = reviewAcception.IsAccepted;
                await _db.Update(found);
                return Ok(found);
            }
            return BadRequest("Review not found");
        }
    }
}
