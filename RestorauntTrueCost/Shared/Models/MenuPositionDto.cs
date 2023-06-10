using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Shared.Models
{
    public class MenuPositionDto
    {
        public MenuPosition menuPosition { get; set; } = null!;
        public byte[]? FileData { get; set; }
    }
}
