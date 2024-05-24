namespace Stashify.Views;

public partial class WantsPage : ContentPage
{
	public WantsPage()
	{
		InitializeComponent();
	}

	private async void ReturnBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}