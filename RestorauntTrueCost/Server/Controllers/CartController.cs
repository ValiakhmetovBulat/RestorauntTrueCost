using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Security.Claims;

namespace RestorauntTrueCost.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        ICartToPositionRepository _db;
        
        public CartController(ICartToPositionRepository db)
        {
            _db = db;
        }

        [Authorize]
        [HttpGet("mycart")]
        public async Task<ActionResult<IEnumerable<CartToPosition>>> GetUserCart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);            

            if (userId != null)
            {
                if (Int32.TryParse(userId, out int id))
                {
                    var cartPositions = await _db.Find(c => c.UserId == id);

                    cartPositions = cartPositions.OrderBy(c => c.MenuPosition.Name).ToList();

                    return Ok(cartPositions);
                }
                else
                {
                    return BadRequest("Invalid UserId");
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        [Authorize]
        [HttpDelete("clear")]
        public async Task<ActionResult<IEnumerable<CartToPosition>>> ClearUserCart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                if (Int32.TryParse(userId, out int id))
                {
                    var cartPositions = await _db.Find(c => c.UserId == id);

                    _db.RemoveRange(cartPositions);
                    return Ok(cartPositions);
                }
                else
                {
                    return BadRequest("Invalid UserId");
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        [Authorize]
        [HttpDelete("removeall/{positionId}")]
        public async Task<ActionResult<IEnumerable<CartToPosition>>> RemoveAllCartPosition(int positionId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                if (Int32.TryParse(userId, out int id))
                {
                    var foundCartPositions = await _db.Find(c => c.UserId == id && c.MenuPositionId == positionId);

                    _db.RemoveRange(foundCartPositions);
                    return Ok(foundCartPositions);
                }
                else
                {
                    return BadRequest("Invalid UserId");
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        [Authorize]
        [HttpPost("add/{positionId}")]
        public async Task<ActionResult<IEnumerable<CartToPosition>>> CreateCartPosition(int positionId)
        {
            CartToPosition cartPosition = new CartToPosition();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                if (Int32.TryParse(userId, out int id))
                {
                    var foundCartPosition = await _db.Find(c => c.UserId == id && c.MenuPositionId == positionId);

                    if (foundCartPosition.Count() > 0)
                    {
                        var existedCartPosition = foundCartPosition.FirstOrDefault();

                        existedCartPosition.Count++;

                        await _db.Update(existedCartPosition);
                        return Ok(existedCartPosition);
                    }
                    else
                    {
                        cartPosition.UserId = id;
                        cartPosition.MenuPositionId = positionId;
                        cartPosition.Count = 1;

                        try
                        {
                            await _db.Create(cartPosition);
                        }
                        catch (Exception)
                        {
                            return BadRequest("Position doesn't exists");
                        }
                       
                        return Ok(cartPosition);
                    }                    
                }
                else
                {
                    return BadRequest("Invalid UserId");
                }                
            }
            else
            {
                return BadRequest("User was null");
            }
        }

        [Authorize]
        [HttpPost("remove/{positionId}")]
        public async Task<ActionResult<IEnumerable<CartToPosition>>> RemoveOneCartPosition(int positionId)
        {
            CartToPosition cartPosition = new CartToPosition();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                if (Int32.TryParse(userId, out int id))
                {
                    var foundCartPosition = await _db.Find(c => c.UserId == id && c.MenuPositionId == positionId);

                    if (foundCartPosition.Count() > 0)
                    {
                        var existedCartPosition = foundCartPosition.FirstOrDefault();

                        if (existedCartPosition.Count == 1)
                        {
                            await _db.Delete(existedCartPosition);
                            return Ok(existedCartPosition);
                        }
                        else
                        {
                            existedCartPosition.Count--;

                            await _db.Update(existedCartPosition);
                            return Ok(existedCartPosition);
                        }                        
                    }
                    else
                    {
                        return BadRequest("Cart position not found");
                    }
                }
                else
                {
                    return BadRequest("Invalid UserId");
                }
            }
            else
            {
                return BadRequest("User was null");
            }
        }
    }
}