namespace TheBartendingApp.Views;

public partial class SearchDrinkNameBindingPage : ContentPage
{
		
	public SearchDrinkNameBindingPage(string drinkName)
	{
		InitializeComponent();
		
		BindingContext = new ViewModels.SearchDrinkNameViewModel(drinkName);
		
		
		
	}
}