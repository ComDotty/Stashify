namespace Stashify.Views.Secure;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private async void LoginBtn_Click(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new LoginPage());
	}

}