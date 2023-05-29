using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestorauntTrueCost.Shared.Entities;

public partial class Section
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NameRU { get; set; }
    //[JsonIgnore]

    //public virtual ICollection<PositionType> PositionTypes { get; } = new List<PositionType>();
}
