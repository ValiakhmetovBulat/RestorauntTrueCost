using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestorauntTrueCost.Shared.Entities;

public partial class MenuPosition
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Price { get; set; }
    public int PositionTypeId { get; set; }
    public virtual PositionType? PositionType { get; set; } = null!;
    public string? Decription { get; set; }
    public string? Photo { get; set; }
}
