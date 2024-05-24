using Stashify.Views.Secure;

namespace Stashify
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WelcomePage();
        }
    }
}
