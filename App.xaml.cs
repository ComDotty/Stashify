using Stashify.Views.Secure;

namespace Stashify
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

    #pragma warning disable CS8602 // Dereference of a possibly null reference.
        public static new App Current => (App)Application.Current!;
        public IServiceProvider Services => Current.Handler.MauiContext.Services;
    #pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}