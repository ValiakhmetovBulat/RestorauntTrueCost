using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestorauntApi.Models.EntititesRepositories.Interfaces;
using RestorauntTrueCost.Client.ViewModels;
using RestorauntTrueCost.Server.Models;
using RestorauntTrueCost.Shared.Entities;
using RestorauntTrueCost.Shared.Models;
using System;
using System.Security.Claims;

namespace RestorauntTrueCost.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _db;

        public UserController(IUserRepository db)
        {
            _db = db;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IEnumerable<User>> Get() => await _db.GetAll();

        [Authorize(Roles = "Admin")]
        [HttpGet("getbyid/{userId}")]
        public async Task<ActionResult<User>> GetUserById(int userId)
        {
            var user = await _db.GetById(userId);

            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        } 

        [HttpPost("register")]
        public async Task<ActionResult<User>> RegisterUser(UserDto user)
        {
            if (_db.Find(u => u.Email == user.Email).Result.FirstOrDefault() != null)
            {
                return BadRequest("Данная почта уже зарегестрирована в системе");
            }

            User registeredUser = new User
            {
                Password = Encryption.Encrypt(user.Password),
                Email = user.Email,
                RegistrationDate = DateTime.UtcNow,
                RoleId = 3
            };

            await _db.Create(registeredUser);
            return await Task.FromResult(registeredUser);

        }

        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            if (_db.Find(u => u.Email == user.Email).Result.FirstOrDefault() != null)
            {
                return BadRequest("Данная почта уже зарегестрирована в системе");
            }

            await _db.Create(user);
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginUser([FromBody] UserDto user)
        {
            user.Password = Encryption.Encrypt(user.Password);
            User loguser = _db.Find(u => u.Email == user.Email && u.Password == user.Password).Result.FirstOrDefault();

            if (loguser != null)
            {       
                var claimEmail = new Claim(ClaimTypes.Email, loguser.Email);
                var claimNameIdentifier = new Claim(ClaimTypes.NameIdentifier, loguser.Id.ToString());
                var claimRole = new Claim(ClaimTypes.Role, Convert.ToString(loguser.Role.Name)); 
                var claimsIdentity = new ClaimsIdentity(new[] { claimEmail, claimNameIdentifier, claimRole }, "serverAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal, _getAuthenticationProperties());
            }

            return await Task.FromResult(loguser);
        }

        [HttpGet("whoami")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();

            if (User.Identity.IsAuthenticated)
            {
                currentUser.Email = User.FindFirstValue(ClaimTypes.Email); 
                currentUser = _db.Find(u => u.Email == currentUser.Email).Result.FirstOrDefault();

                if (currentUser == null)
                {
                    return Ok(new User());
                }                
            }
            return Ok(currentUser);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("update/{userId}")]
        public async Task<ActionResult<User>> UpdateUser(int userId, [FromBody] UpdateUserDto user)
        {
            var foundUser = await _db.GetById(userId);
            if (foundUser != null)
            {
                foundUser.Surname = user.Surname;
                foundUser.Email = user.Email;
                foundUser.Name = user.Name;
                foundUser.Phone = user.Phone;
                foundUser.RoleId = user.RoleId;
                await _db.Update(foundUser);
                return Ok(foundUser);
            }
            return BadRequest("User not found");
        }

        [HttpGet("logout")]
        public async Task<ActionResult<string>> LogoutUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
                return "Sucess";
            }
            else
            {
                return BadRequest("Not authorized");
            }
        }

        [Authorize]
        [HttpPut("updateprofile/{userId}")]
        public async Task<IActionResult> UpdateProfile(int userId, [FromBody] ProfileDto profile)
        {
            if (User.FindFirstValue(ClaimTypes.NameIdentifier) == userId.ToString())
            {
                User userToUpdate = _db.Find(u => u.Id == userId).Result.FirstOrDefault();

                if (_db.Find(u => u.Email == profile.Email).Result.FirstOrDefault() != null && profile.Email != User.FindFirstValue(ClaimTypes.Email))
                {
                    return BadRequest();
                }

                userToUpdate.Name = profile.Name;
                userToUpdate.Surname = profile.Surname;
                if (!(string.IsNullOrWhiteSpace(profile.Email)))
                {
                    userToUpdate.Email = profile.Email;
                }
                userToUpdate.Phone = profile.Phone;

                await _db.Update(userToUpdate);
                return Ok(userToUpdate);
            }

            return Forbid();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{userId}")]
        public async Task<ActionResult<User>> DeleteUser(int userId)
        {
            var user = await _db.GetById(userId);
            if (user != null)
            {
                await _db.Delete(user);
                return Ok(user);
            }

            return NotFound();
        }

        [Authorize]
        [HttpGet("getprofile/{userId}")]
        public async Task<ProfileDto> GetProfile(int userId)
        {
            var user = _db.Find(u => u.Id == userId).Result.FirstOrDefault();
            ProfileDto profile = new ProfileDto()
            {
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                Phone = user.Phone
            };

            return profile;
        }

        [HttpGet("GoogleSignIn")]
        public async Task GoogleSignIn()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme,
                _getAuthenticationProperties());
        }

        [HttpGet("notauthorized")]
        public IActionResult NotAuthorized()
        {
            return Unauthorized();
        }

        private AuthenticationProperties _getAuthenticationProperties()
        {
            return new AuthenticationProperties()
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.Now.AddDays(1),
                RedirectUri = "/profile/update",
            };
        }
        
    }
}
