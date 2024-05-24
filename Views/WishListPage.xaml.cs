namespace Stashify.Views;

public partial class WishListPage : ContentPage
{
	public WishListPage()
	{
		InitializeComponent();
	}

	private async void ReturnBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}