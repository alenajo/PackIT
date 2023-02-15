namespace RMA_Tim6.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();

        Ime.Text = "Ime Prezime";
        Lokacija.Text = "Zenica, Bosna i Hercegovina";
        Bio.Text = "Lorem ipsum dolor sit amet.";
        Email.Text = "ime.prezime@size.ba";
        Cat1.Text = "Summer";
        Cat2.Text = "Winter";
        Cat3.Text = "Camping";
    }
}