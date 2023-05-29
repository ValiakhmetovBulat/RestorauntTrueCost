namespace RestorauntTrueCost.Client.ViewModels.Interfaces
{
    public interface IOrderPrepareViewModel
    {
        public Task<bool> IsCartEmpty();
    }
}
