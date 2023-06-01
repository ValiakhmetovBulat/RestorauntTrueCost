﻿using RestorauntTrueCost.Shared.Helpers.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace RestorauntTrueCost.Shared.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    [EmailAddress]
    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    [MinLength(6, ErrorMessage = "Минимальная длина пароля - 6 символов")]
    [MaxLength(20, ErrorMessage = "Максимальная длина пароля - 20 символов")]
    [HasDigits(1, ErrorMessage = "Пароль должен содержать хотя бы одну цифру")]
    [HasLetters(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву")]
    [HasUpper(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву верхнего регистра")]
    [HasLower(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву нижнего регистра")]
    [Required(ErrorMessage = "Поле не может быть пустым")]
    public string Password { get; set; } = null!;

    public int RoleId { get; set; }
    public virtual Role? Role { get; set; }

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public override string ToString()
    {
        return $"|{Id}| {Surname} {Name}";
    }
}