namespace RestorauntTrueCost.Client.ViewModels.Interfaces
{
    public interface IProfileViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string? Phone { get; set; }

        public Task UpdateProfile();
        public Task GetProfile();
    }
}
