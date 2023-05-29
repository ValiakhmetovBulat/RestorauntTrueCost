using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Client.ViewModels.Interfaces
{
    public interface IOrderHistoryViewModel
    {
        Task GetOrderHistory();
        List<Order> OrderHistory { get; set; }
    }
}
