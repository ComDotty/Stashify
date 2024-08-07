using System.Windows.Input;
using Microsoft.Maui.Controls;
using Stashify.Models;
using Stashify.ViewModels;

namespace Stashify.Views;

public partial class HomePage : ContentPage
{
    private readonly HomePageVM? _viewModel;	
    private const uint AnimationDuration = 800u;

	public HomePage()
	{
		InitializeComponent();

        // Assign the viewmodel binding context
        _viewModel = App.Current.Services.GetRequiredService<HomePageVM>();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Ensure ViewModel is not null and load data
        _viewModel?.LoadData();
    }
    private void MenuBtn_Click(object sender, EventArgs e)
    {
        //Display the menu and move the MainContentGrid out of the view
        _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
        _ = MainContentGrid.TranslateTo(-400, 0, AnimationDuration, Easing.CubicInOut);
    }

    private async void PageColletionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (HomePageCollectionView.SelectedItem != null)
        {
            Home selItem = (Home)HomePageCollectionView.SelectedItem;
            var pgId = selItem.SectionId;

            Page? newPage = null;

            switch (pgId)
            {

                case 1:
                    newPage = new StashPage();
                    break;

                case 2:
                    newPage = new WishListPage();
                    break;

                case 3:
                    newPage = new ShoppingListPage();
                    break;

                default:
                    break;
            }
               
        if (newPage != null)
        {

            await Dispatcher.DispatchAsync(async () =>
                {
                    await Navigation.PushAsync(newPage, true);
                });
            
            }
        }
    }
}