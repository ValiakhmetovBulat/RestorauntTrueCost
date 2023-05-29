using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorauntTrueCost.Shared.Entities
{
    public class OrderPeriod
    {
        public int Id { get; set; }
        public string FromTo { get; set; } = null!;
    }
}
