using RestorauntTrueCost.Shared.Helpers.Validations;
using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Models
{
    public class ProfileDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        [EmailValidator]
        [EmailAddress]
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
