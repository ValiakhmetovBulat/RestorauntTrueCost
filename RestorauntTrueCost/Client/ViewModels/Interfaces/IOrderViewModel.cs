using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Client.ViewModels.Interfaces
{
    public interface IOrderViewModel
    {
        int UserId { get; set; }
        List<Table> Tables { get; set; }
        DateTime ReservedDate { get; set; }
        string FromTo { get; set; }
        List<OrderPeriod> Periods { get; set; }
        Task GetPeriodsAsync();
        int CalculateTotalSum();
        Task CreateOrder();
        string Message { get; set; }
        List<CartToPosition> Cart { get; set; }
        Task GetCart();
        Task ClearCart();
        void ClearTables();
    }
}
