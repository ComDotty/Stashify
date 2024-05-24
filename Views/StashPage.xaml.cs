namespace Stashify.Views;

public partial class StashPage : ContentPage
{
	public StashPage()
	{
		InitializeComponent();
	}

	private async void ReturnBtn_Click(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}