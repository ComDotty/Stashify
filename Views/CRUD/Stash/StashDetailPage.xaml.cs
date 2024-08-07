namespace Stashify.Views.CRUD.Stash;

public partial class StashDetailPage : ContentPage
{
    public StashDetailPage(int productId)
    {
        InitializeComponent();

        // Fetch the Stash item by productId and set it as the BindingContext
        var stashItem = Models.Stash.GetItemById(productId);
        BindingContext = stashItem;
    }

    private async void OnPageTapped(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}