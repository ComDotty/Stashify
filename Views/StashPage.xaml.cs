using Microsoft.Extensions.DependencyInjection;
using Stashify.Models;
using Stashify.ViewModels;
using Stashify.Views.Controls;
using Stashify.Views.CRUD.Stash;

namespace Stashify.Views;

public partial class StashPage : ContentPage
{
    private readonly StashPageVM? _viewModel;
    private const uint AnimationDuration = 800u;
    private bool isSwiping = false;

    public StashPage()
    {
        InitializeComponent();

        // Assign the viewmodel binding context
        _viewModel = App.Current.Services.GetRequiredService<StashPageVM>();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Ensure ViewModel is not null and load data
        _viewModel?.LoadInitialItems();  // Load initial items when the page appears
    }

    private void MenuBtn_Click(object sender, EventArgs e)
    {
        // Display the menu and move the MainContentGrid out of the view
        _ = MainContentGrid.FadeTo(0.6, AnimationDuration);
        _ = MainContentGrid.TranslateTo(-400, 0, AnimationDuration, Easing.CubicInOut);
    }

    private async void PageCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (isSwiping)
        {
            // If swiping, ignore the selection change
            return;
        }

        if (StashPageCollectionView.SelectedItem != null)
        {
            Stash selItem = (Stash)StashPageCollectionView.SelectedItem;
            var prodId = selItem.ProductId;

            if (prodId != 0)
            {
                await Dispatcher.DispatchAsync(async () =>
                {
                    await Navigation.PushAsync(new StashDetailPage(prodId), true);
                });

                // Deselect the item after page navigation
                StashPageCollectionView.SelectedItem = null;
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
        StashPageCollectionView.SelectedItem = null;
    }

    private void ItemsPerPagePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ItemsPerPagePicker.SelectedIndex == -1) return;

        if (_viewModel != null)
        {
            var selectedOption = ItemsPerPagePicker.SelectedItem.ToString();
            _viewModel.ItemsPerPageOption = selectedOption;  // Update the ItemsPerPageOption in the ViewModel
        }
        ItemsPerPagePicker.HidePicker();
    }

    private void PickerBtn_Click(object sender, EventArgs e)
    {
        if (ItemsPerPagePicker.IsVisible == true)
        {
            ItemsPerPagePicker.IsVisible = false;
        }

        ItemsPerPagePicker.ShowPicker();
    }
}

