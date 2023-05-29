using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestorauntTrueCost.Shared.Entities
{
    public class TableOrder
    {
        public int Id { get; set; }        
        public DateTime ReservedDate { get; set; }
        public int OrderPeriodId { get; set; }
        public virtual OrderPeriod? OrderPeriod { get; set; }
        public int OrderId { get; set; }
        [JsonIgnore]
        public virtual Order? Order { get; set; }
        public int TableId { get; set; }
        
        public virtual Table? Table { get; set; }
    }
}
