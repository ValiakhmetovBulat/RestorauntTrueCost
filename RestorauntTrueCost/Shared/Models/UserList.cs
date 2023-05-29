using RestorauntTrueCost.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorauntTrueCost.Shared.Models
{
    public class UserList
    {
        public string SearchTerm { get; set; }
        public List<User>? Users { get; set; }
        public int TotalPages { get; set; }
        public int PageNumber { get; set; }
    }
}
