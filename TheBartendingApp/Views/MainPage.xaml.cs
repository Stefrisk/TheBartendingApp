namespace TheBartendingApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClickedEnter(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }

}
