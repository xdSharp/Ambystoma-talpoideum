namespace IbragimovLaba5
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        
        

        private void GoToRegistrationPage(object sender, EventArgs e)
        {
            AppShell.Current.GoToAsync(nameof(RegPage), true);
        }
        private void GoToMenuPage(object sender, EventArgs e)
        {
            AppShell.Current.GoToAsync(nameof(MenuPage), true);
        }


    }

}
