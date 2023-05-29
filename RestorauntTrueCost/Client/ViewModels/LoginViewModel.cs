using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using System.Net;
using RestorauntTrueCost.Shared.Models;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class LoginViewModel : ILoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "user@example.com";
        [Required]
        public string Password { get; set; } = "string";
        public string Message { get; set; }

        private readonly HttpClient _httpClient;

        public LoginViewModel()
        {
            
        }
        public LoginViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> LoginUser()
        {
            var resp = await _httpClient.PostAsJsonAsync<UserDto>("api/user/login", this);
            if (!(resp.StatusCode == HttpStatusCode.OK))
            {
                this.Message = "Неверный email или пароль";
            }

            return resp;
        }

        public static implicit operator LoginViewModel(UserDto user)
        {
            return new LoginViewModel
            {
                Email = user.Email,
                Password = user.Password
            };
        }

        public static implicit operator UserDto(LoginViewModel vm)
        {
            return new UserDto
            {
                Email = vm.Email,
                Password = vm.Password
            };
        }
    }
}
