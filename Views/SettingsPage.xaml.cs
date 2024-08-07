namespace Stashify.Views;

public partial class SettingsPage : ContentPage
{
	
    private const uint AnimationDuration = 800u;

	public SettingsPage()
	{
		InitializeComponent();
	}

    private void MenuBtn_Click(object sender, EventArgs e)
    {
        //Display the menu and move the MainContentGrid out of the view
        _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
        _ = MainContentGrid.TranslateTo(-400, 0, AnimationDuration, Easing.CubicInOut);
    }
}