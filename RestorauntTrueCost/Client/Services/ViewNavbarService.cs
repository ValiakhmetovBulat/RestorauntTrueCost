namespace RestorauntTrueCost.Client.Services
{
    public class ViewNavbarService
    {
        private bool _navBarVisible = true;

        public Action OnChanged { get; set; }

        public void Toggle()
        {
            _navBarVisible = !_navBarVisible;
            if (OnChanged != null) OnChanged();
        }

        public void Hide()
        {
            _navBarVisible = false;
        }

        //get additional css class for nav bar div
        public string NavBarClass
        {
            get
            {
                if (_navBarVisible) 
                    return string.Empty;

                return "d-none";
            }
        }
    }
}
