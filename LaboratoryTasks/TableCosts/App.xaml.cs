using IbragimovLaba5.DatabaseContext;

namespace IbragimovLaba5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            BdZatrat dbContext = new BdZatrat();
            dbContext.Database.EnsureCreated();
        }
    }
}
