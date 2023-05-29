using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Net.Http.Json;
using System.Net;
using System.ComponentModel.DataAnnotations;
using RestorauntTrueCost.Shared.Helpers.Validations;
using RestorauntTrueCost.Shared.Models;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class ProfileViewModel : IProfileViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string Message { get; set; }
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string? Phone { get; set; }
        [EmailValidator]
        public string Email { get; set; }

        private HttpClient _httpClient;

        public ProfileViewModel()
        {
            
        }
        public ProfileViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task UpdateProfile()
        {
            ProfileDto profile = this;
            var resp = await _httpClient.PutAsJsonAsync("api/user/updateprofile/" + this.UserId, profile);
            if (resp.StatusCode == HttpStatusCode.OK)
            {
                this.Message = "Профиль был успешно изменен";
            }
            else
            {
                this.Message = "Произошла ошибка при изменении профиля";
            }
        }

        public async Task GetProfile()
        {
            ProfileDto profile = await _httpClient.GetFromJsonAsync<ProfileDto>("api/user/getprofile/" + this.UserId);
            LoadCurrentObject(profile);
            this.Message = "Профиль был успешно загружен";
        }

        private void LoadCurrentObject(ProfileViewModel model)
        {
            this.Name = model.Name;
            this.Surname = model.Surname;
            this.Email = model.Email;
            this.Phone = model.Phone;
        }
        public static implicit operator ProfileViewModel(ProfileDto profile)
        {
            return new ProfileViewModel
            {
                Name = profile.Name,
                Surname = profile.Surname,
                Email = profile.Email,
                Phone = profile.Phone
            };
        }
        public static implicit operator ProfileDto(ProfileViewModel model)
        {
            return new ProfileDto
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                Phone = model.Phone
            };
        }
    }
}
