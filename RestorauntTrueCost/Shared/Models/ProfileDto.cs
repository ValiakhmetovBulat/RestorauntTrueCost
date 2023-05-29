using RestorauntTrueCost.Shared.Helpers.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
