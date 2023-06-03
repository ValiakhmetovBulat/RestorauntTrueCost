using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Shared.Models
{
    public class MenuPositionDto
    {
        public MenuPosition menuPosition { get; set; } = null!;
        public IBrowserFile? formFile { get; set; }
    }
}
