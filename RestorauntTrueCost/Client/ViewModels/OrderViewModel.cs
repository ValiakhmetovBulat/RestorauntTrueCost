using RestorauntTrueCost.Client.Components;
using RestorauntTrueCost.Client.Pages;
using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Net.Http.Json;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class OrderViewModel : IOrderViewModel
    {
        public int UserId { get; set; }
        public List<Table> Tables { get; set; } = new List<Table>();
        public DateTime ReservedDate { get; set; } = DateTime.Now.Date;
        public string FromTo { get; set; }
        public List<OrderPeriod> Periods { get; set; } = new List<OrderPeriod>();
        public string Message { get; set; }
        public List<CartToPosition> Cart { get; set; } = new List<CartToPosition>();

        private HttpClient _httpClient;

        public OrderViewModel()
        {

        }
        public OrderViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetPeriodsAsync()
        {
            Periods = await _httpClient.GetFromJsonAsync<List<OrderPeriod>>("api/orderperiod");
        }

        public async Task GetCart()
        {
            Cart = await _httpClient.GetFromJsonAsync<List<CartToPosition>>("api/cart/mycart");
        }

        public async Task ClearCart()
        {
            await _httpClient.DeleteFromJsonAsync<List<CartToPosition>>("api/cart/clear");
        }

        public void ClearTables()
        {
            Tables = new List<Table>();
        }

        public async Task CreateOrder()
        {
            if (string.IsNullOrWhiteSpace(FromTo))
            {                
                this.Message = "Пожалуйста, выберите время бронирования";
                return;
            }
            if (Tables.Count == 0)
            {
                this.Message = "Пожалуйста, выберите столы для бронирования";
                return;
            }
            RestorauntTrueCost.Shared.Entities.Order order = new RestorauntTrueCost.Shared.Entities.Order();            

            order.CreatedDate = DateTime.Now;            
            order.TotalSum = CalculateTotalSum();
            order.OrderStatusId = 1;

            if (Cart.Count > 0)
            {
                foreach (var cartToPosition in Cart)
                {
                    order.OrderToPositions.Add(new OrderToPosition()
                    {
                        MenuPositionId = cartToPosition.MenuPositionId,
                        Count = cartToPosition.Count,
                    });
                    order.TotalSum += cartToPosition.Count * cartToPosition.MenuPosition.Price;
                }
            }

            foreach (var table in Tables)
            {
                order.TableOrders.Add(new TableOrder()
                {
                    TableId = table.Id,
                    ReservedDate = ReservedDate,
                    OrderPeriodId = Periods.Find(p => p.FromTo == FromTo).Id
                });
            }

            var resp = await _httpClient.PostAsJsonAsync("api/order/createorder", order);
        }

        public int CalculateTotalSum()
        {
            int sum = 0;

            foreach (var table in Tables)
            {
                sum += table.ReserveCost;
            }

            return sum;
        }

        public void AddTableToOrder (Table table)
        {
            if (Tables.Contains(table))
            {
                Tables.Remove(table);
            }
            else
            {
                Tables.Add(table);
            }
        }
    }
}
