namespace Stashify.Views.Secure;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Click(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new HomePage());
	}

    private async void CancelBtn_Click(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
	}
}