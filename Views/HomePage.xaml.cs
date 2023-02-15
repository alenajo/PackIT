using RMA_Tim6.Models;
using RMA_Tim6.ViewModels;
namespace RMA_Tim6.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel();
	}

    /* private async void Trips_ItemTapped(object sender, EventArgs e)
    {
        var myListView = (CollectionView)sender;
        var odabranoPutovanje = (Putovanje)myListView.SelectedItem;
        await Navigation.PushModalAsync(new NavigationPage(new DetailsPage(odabranoPutovanje)));
    } */

    public async void CreateTrip_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(GeneratorPage)}");
    }
}