using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Shared.Models
{
    public class MenuPositionDto
    {
        public MenuPosition menuPosition { get; set; } = null!;
        public byte[]? FileData { get; set; }
    }
}
