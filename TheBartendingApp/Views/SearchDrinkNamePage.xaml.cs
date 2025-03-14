namespace TheBartendingApp.Views;

public partial class SearchDrinkNamePage : ContentPage
{
	
	
	public SearchDrinkNamePage()
	{
		
		InitializeComponent();
	}

    private async void OnClickedGetDrink(object sender, EventArgs e)
    {
		
		await Navigation.PushAsync(new Views.SearchDrinkNameBindingPage(DrinkSearch.Text));
    }
}