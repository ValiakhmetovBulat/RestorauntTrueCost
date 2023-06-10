using RestorauntTrueCost.Shared.Entities;

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
