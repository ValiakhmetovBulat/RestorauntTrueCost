using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RestorauntTrueCost.Shared.Entities;

public partial class Review
{
    public int Id { get; set; }    

    public DateTime DateOfVisit { get; set; }

    public int? NumberOfGuests { get; set; }

    public int? TableNumber { get; set; }

    [MinLength(1)]
    [Required]
    public string Message { get; set; } = null!;

    public bool IsAccepted { get; set; }

    public int UserId { get; set; }
    public DateTime DatePosted { get; set; } = DateTime.Now;

    public virtual User? User { get; set; }
}
