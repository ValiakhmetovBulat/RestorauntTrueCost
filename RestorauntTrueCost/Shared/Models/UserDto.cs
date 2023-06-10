using RestorauntTrueCost.Shared.Helpers.Validations;
using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Models
{
    public class UserDto
    {
        [EmailValidator]
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
