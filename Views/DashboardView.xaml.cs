using RMA_Tim6.Models;

namespace RMA_Tim6.Views;

public partial class DashboardView : ContentPage
{
    User newUser = new User
    {
        Ime = "Ime",
        Prezime = "Prezime",
        Username = "Username",
        Sifra = "123456",
        Email = "Email"
    };
    public DashboardView()
	{
		InitializeComponent();
	}

    public async void Login_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new LoginPageView(newUser));
    }
    public async void Register_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
    }
}