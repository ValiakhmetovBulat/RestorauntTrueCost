namespace RestorauntTrueCost.Client.ViewModels.Interfaces
{
    public interface IFeedbackViewModel
    {
        public int UserId { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int? NumberOfGuests { get; set; }
        public int? TableNumber { get; set; }
        public string Message { get; set; }
        public Task SendFeedback();
        public string Status { get; set; }
    }
}
