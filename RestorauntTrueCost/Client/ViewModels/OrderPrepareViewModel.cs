using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Net.Http.Json;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class OrderPrepareViewModel : IOrderPrepareViewModel
    {
        private HttpClient _httpClient;

        public OrderPrepareViewModel()
        {

        }

        public OrderPrepareViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> IsCartEmpty()
        {
            var resp = await _httpClient.GetFromJsonAsync<List<CartToPosition>>("api/cart/mycart");

            if (resp.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
