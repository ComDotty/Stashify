using Stashify.Models;
using Stashify.ViewModels;
using Stashify.Views.CRUD.WishList;

namespace Stashify.Views;

public partial class WishListPage : ContentPage
{
    private readonly WishListPageVM? _viewModel;
    private const uint AnimationDuration = 800u;
    private bool isSwiping = false;

	public WishListPage()
	{
		InitializeComponent();

        // Assign the viewmodel binding context
        _viewModel = App.Current.Services.GetRequiredService<WishListPageVM>();
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

    private async void PageCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (isSwiping)
        {
            // If swiping, ignore the selection change
            return;
        }
        
        if (WishListPageCollectionView.SelectedItem != null)
        {
            Wish selItem = (Wish)WishListPageCollectionView.SelectedItem;
            var prodId = selItem.ProductId;

        if (prodId != 0)
                {
                    await Dispatcher.DispatchAsync(async () =>
                    {
                        await Navigation.PushAsync(new WishListDetailPage(prodId), true);
                    });

                    // Deselect the item after page navigation
                    WishListPageCollectionView.SelectedItem = null;
            }
        }
    }

    private void OnSwipeStarted(object sender, EventArgs e)
    {
        isSwiping = true;
    }

    private void OnSwipeEnded(object sender, EventArgs e)
    {
        isSwiping = false;

        // Reset the SelectedItem after swipe has finished
        WishListPageCollectionView.SelectedItem = null;

    }
}