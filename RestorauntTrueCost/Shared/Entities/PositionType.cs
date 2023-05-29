using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestorauntTrueCost.Shared.Entities;

public partial class PositionType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string NameRu { get; set; } = null!;

    public int? SectionId { get; set; }

    public virtual Section? Section { get; set; }
}
