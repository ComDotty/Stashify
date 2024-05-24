namespace Stashify.Views.Secure;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

	private async void ReturnBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}