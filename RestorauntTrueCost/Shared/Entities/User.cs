using RestorauntTrueCost.Shared.Helpers.Validations;
using System.ComponentModel.DataAnnotations;

namespace RestorauntTrueCost.Shared.Entities;

public partial class User
{
    public int Id { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    [EmailAddress]
    public string Email { get; set; } = null!;

    [MinLength(6, ErrorMessage = "Минимальная длина пароля - 6 символов")]
    [HasDigits(1, ErrorMessage = "Пароль должен содержать хотя бы одну цифру")]
    [HasLetters(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву")]
    [HasUpper(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву верхнего регистра")]
    [HasLower(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву нижнего регистра")]
    [Required(ErrorMessage = "Поле не может быть пустым")]
    public string Password { get; set; } = null!;
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Surname { get; set; }
    public int RoleId { get; set; }
    public virtual Role? Role { get; set; }

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public override string ToString()
    {
        return $"|{Id}| {Surname} {Name}";
    }
}
