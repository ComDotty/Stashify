namespace Stashify.Views;

public partial class ShoppingListPage : ContentPage
{
	public ShoppingListPage()
	{
		InitializeComponent();
	}

	private async void ReturnBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}