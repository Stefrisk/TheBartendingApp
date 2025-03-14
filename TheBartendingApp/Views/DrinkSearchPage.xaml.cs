namespace TheBartendingApp.Views;

public partial class DrinkSearchPage : ContentPage
{
	public DrinkSearchPage()
	{
		InitializeComponent();
	}

    private async void OnClickedDrinkName(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new SearchDrinkNamePage());
    }
}