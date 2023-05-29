using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Net.Http.Json;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class OrderHistoryViewModel : IOrderHistoryViewModel
    {
        private HttpClient _httpClient;
        public List<Order> OrderHistory { get; set; } = new List<Order>();

        public OrderHistoryViewModel()
        {

        }

        public OrderHistoryViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetOrderHistory()
        {
            OrderHistory = await _httpClient.GetFromJsonAsync<List<Order>>("api/order/myorders");
        }
    }
}
