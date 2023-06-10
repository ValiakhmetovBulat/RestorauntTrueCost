using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Helpers.Validations;
using RestorauntTrueCost.Shared.Models;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class RegistrationViewModel : IRegistrationViewModel
    {
        [EmailValidator(ErrorMessage = "Некорректный Email")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string Email { get; set; } = null!;
        [MinLength(6, ErrorMessage = "Минимальная длина пароля - 6 символов")]
        [HasDigits(1, ErrorMessage = "Пароль должен содержать хотя бы одну цифру")]
        [HasLetters(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву")]
        [HasUpper(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву верхнего регистра")]
        [HasLower(1, ErrorMessage = "Пароль должен содержать хотя бы одну букву нижнего регистра")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirmation { get; set; } = null!;
        public string Message { get; set; }

        private HttpClient _httpClient;

        public RegistrationViewModel()
        {

        }

        public RegistrationViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> Register()
        {
            UserDto user = this;
            var resp = new HttpResponseMessage();

            if (Password == PasswordConfirmation)
            {
                resp = await _httpClient.PostAsJsonAsync("api/user/register", user);
                if (resp.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    this.Message = await resp.Content.ReadAsStringAsync();
                }
                else
                {
                    this.Message = "Успешная регистрация";
                }
            }
            else
            {
                resp.StatusCode = System.Net.HttpStatusCode.BadRequest;
                this.Message = "Пароли не совпадают";
            }

            return resp;
        }

        public static implicit operator RegistrationViewModel(UserDto user)
        {
            return new RegistrationViewModel
            {
                Email = user.Email,
                Password = user.Password,
            };
        }

        public static implicit operator UserDto(RegistrationViewModel registrationViewModel)
        {
            return new UserDto
            {
                Email = registrationViewModel.Email,
                Password = registrationViewModel.Password,
            };
        }
    }
}
