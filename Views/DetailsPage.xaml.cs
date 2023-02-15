using RMA_Tim6.Models;
using RMA_Tim6.ViewModels;

namespace RMA_Tim6.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Putovanje _putovanje)
	{
		InitializeComponent();
		
        putovanjeName.Text = _putovanje.Name;
		location.Text = _putovanje.Location;
		category.Text = _putovanje.Category;
		duration.Text = _putovanje.Duration;
		ImageUrl.Source = _putovanje.ImageUrl;
		//liste 
		
    }
    private async void Favorite_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Favorites", "Trip added to favorites", "OK");

    }
}