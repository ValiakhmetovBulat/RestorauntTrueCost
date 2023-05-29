namespace RestorauntTrueCost.Client.ViewModels.Interfaces
{
    public interface IRegistrationViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Task<HttpResponseMessage> Register();
        public string PasswordConfirmation { get; set; }
        public string Message { get; set; }
    }
}
