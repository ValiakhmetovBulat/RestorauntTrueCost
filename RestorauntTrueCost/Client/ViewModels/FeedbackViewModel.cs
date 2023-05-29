using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class FeedbackViewModel : IFeedbackViewModel
    {
        public int UserId { get; set; }
        public DateTime DateOfVisit { get; set; } = DateTime.Now;
        [Range(1, 50, ErrorMessage = "Количество гостей может быть в диапазоне от 1 до 50")]
        public int? NumberOfGuests { get; set; }
        [Range(1, 50, ErrorMessage = "Номер стола может быть в диапазоне от 1 до 50")]
        public int? TableNumber { get; set; }
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string Message { get; set; }
        public string Status { get; set; }

        private HttpClient _httpClient;

        public FeedbackViewModel()
        {
            
        }

        public FeedbackViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SendFeedback()
        {            
            Review review = this;
            var resp = await _httpClient.PostAsJsonAsync("api/feedback/leavefeedback", review);
            if (resp.IsSuccessStatusCode && review.Message.Length >= 1)
            {
                Status = "Спасибо! Отзыв был успешно отправлен";
            }
            else
            {
                Status = "Ошибка при отправке отызва";
            }
        }

        public static implicit operator FeedbackViewModel(Review review)
        {
            return new FeedbackViewModel
            {
                UserId = review.UserId,
                NumberOfGuests = review.NumberOfGuests,
                TableNumber = review.TableNumber,
                Message = review.Message,
                DateOfVisit = review.DateOfVisit
            };
        }

        public static implicit operator Review(FeedbackViewModel feedbackViewModel)
        {
            return new Review
            {
                UserId = feedbackViewModel.UserId,
                NumberOfGuests = feedbackViewModel.NumberOfGuests,
                TableNumber = feedbackViewModel.TableNumber,
                Message = feedbackViewModel.Message,
                DateOfVisit = feedbackViewModel.DateOfVisit
            };
        }
    }
}
