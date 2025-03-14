namespace TheBartendingApp;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void OnClickedDrinkSearch(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.DrinkSearchPage());
    }
}