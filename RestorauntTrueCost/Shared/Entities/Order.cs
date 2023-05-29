using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorauntTrueCost.Shared.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int TotalSum { get; set; }
        public virtual ICollection<OrderToPosition> OrderToPositions { get; set; } = new List<OrderToPosition>();
        public virtual ICollection<TableOrder> TableOrders { get; set; } = new List<TableOrder>();
        public int OrderStatusId { get; set; }
        public virtual OrderStatus? OrderStatus { get; set; }
    }
}
