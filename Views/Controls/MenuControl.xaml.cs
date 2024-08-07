using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Stashify.Views.Controls;

public partial class MenuControl : ContentView
{
    private const uint AnimationDuration = 800u;

    //Bind the MainContentGrid object of each page to the menu control
    public static readonly BindableProperty MainContentGridProperty =
    BindableProperty.Create(
        nameof(MainContentGrid),
        typeof(Grid),
        typeof(MenuControl),
        default(Grid));

    //Bind the ParentPageProperty of each page to the menu control
    public static readonly BindableProperty ParentPageProperty =
    BindableProperty.Create(
        nameof(ParentPage),
        typeof(Page),
        typeof(MenuControl),
        default(Page));

    public Grid MainContentGrid
    {
        get => (Grid)GetValue(MainContentGridProperty);
        set => SetValue(MainContentGridProperty, value);
    }
            
    public Page ParentPage
    {
        get => (Page)GetValue(ParentPageProperty);
        set => SetValue(ParentPageProperty, value);
    }

    public MenuControl()
    {
        InitializeComponent();
    }

    private async void OnBtnClick(object sender, EventArgs e)
    {
            var button = (Button)sender;
            var page = button.ClassId.ToString();
            
            if (page != null) {
                await ExecuteNavigation(page);
            }
    }

    private async Task ExecuteNavigation(string page)
    {
        await CloseMenu();
        
        if (ParentPage == null)
            return;

        Page? newPage = null;

            switch (page)
            {

                case "AccountPage":
                    newPage = new AccountPage();
                    break;

                case "HomePage":
                    newPage = new HomePage();
                    break;

                case "SettingsPage":
                    newPage = new SettingsPage();
                    break;

                case "ShoppingListPage":
                    newPage = new ShoppingListPage();
                    break;

                case "StashPage":
                    newPage = new StashPage();
                    break;                

                case "WantsPage":
                    newPage = new WantsPage();
                    break;
                    
                case "WishListPage":
                    newPage = new WishListPage();
                    break;

                case "HelpPage":
                    newPage = new HelpPage();
                    break;

                case "AboutPage":
                    newPage = new AboutPage();
                    break;

                case "BuySellTradePage":
                    newPage = new BuySellTradePage();
                    break;

                case "Logout":

                if (Application.Current != null)
                {
                    Application.Current.MainPage = new NavigationPage(new Secure.LoginPage());
                }
                
                await Navigation.PopToRootAsync();
                    break;

                default:
                    break;
            }
               
        if (newPage != null)
        {
            
            if (ParentPage != null)
            {
            await ParentPage.Dispatcher.DispatchAsync(async () =>
                {
                    await ParentPage.Navigation.PushAsync(newPage, true);
                });
            
            }
        }
    }
    
    private async void MenuGrid_Tap(object sender, TappedEventArgs e)
    {
        await CloseMenu();
    }

    private async Task CloseMenu()
    {
        if (MainContentGrid != null)
            {
                await Task.WhenAll(
                    MainContentGrid.FadeTo(1, AnimationDuration),
                    MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicInOut));
            }    
    }
}