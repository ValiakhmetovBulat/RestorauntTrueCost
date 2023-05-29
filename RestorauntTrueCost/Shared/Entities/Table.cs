using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorauntTrueCost.Shared.Entities
{
    public partial class Table
    {
        public int Id { get; set; }
        public int TableNum { get; set; }
        public int GuestNum { get; set; }
        public int ReserveCost { get; set; }
    }
}
