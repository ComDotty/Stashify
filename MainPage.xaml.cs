namespace Stashify
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginBtnClicked(object sender, EventArgs e)
        {
            LoginBtn.Text = "Login Button Clicked";
        }

    }

}
