using P6Assets_KeirynS.Views;


namespace P6Assets_KeirynS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
