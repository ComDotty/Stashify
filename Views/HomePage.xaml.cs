namespace Stashify.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        InitializeComponent();
	}

	private async void StashPgBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new StashPage());
	}

	private async void WantsPgBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new WantsPage());
	}

	private async void WishListPgBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new WishListPage());
	}

	private async void ShoppingListPgBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new ShoppingListPage());
	}

	private async void AccountPgBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new Secure.AccountPage());
	}

	private async void LogoutBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new Secure.WelcomePage());
	}
}