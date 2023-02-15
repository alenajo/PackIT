using RMA_Tim6.Models;
using RMA_Tim6.ViewModels;

namespace RMA_Tim6.Views;

public partial class GeneratorPage : ContentPage
{
	public GeneratorPage()
	{
		InitializeComponent();
        BindingContext = this;

        startDatePicker.MinimumDate = DateTime.Today;
        endDatePicker.MinimumDate = DateTime.Today;

    }

    public void Submit_Clicked(object sender, EventArgs e)
    {
        if (uneseniNaslov.Text is null)
        {
            DisplayAlert("Error", "Please enter the name of your list!", "OK");
        }

        else if ((Gender1Checkbox.IsChecked == true && Gender2Checkbox.IsChecked == true) || (Gender1Checkbox.IsChecked == false && Gender2Checkbox.IsChecked == false))
        {
             DisplayAlert("Error", "You can choose only one gender!", "OK");

        }
        else
        {
            String naslov = uneseniNaslov.Text;

            String trajanje = CalculateDuration();

            String kategorija = (String)categoryPicker.SelectedItem;

            String lokacija = unesenaLokacija.Text;

            String gender; 
            if (Gender1Checkbox.IsChecked) { gender = "Female"; }
            else if (Gender2Checkbox.IsChecked) { gender = "Male"; }

            List<String> Stvari = new List<string>();
         
            /* string poruka = "NOVO PUTOVANJE: " + naslov +
                                            "\r\nDuration: " + trajanje +
                                            "\r\nKategorija: " + kategorija +
                                            "\r\nLokacija: " + lokacija; */

            Putovanje putovanje = new Putovanje();
            putovanje.Name = naslov;
            putovanje.Category = kategorija;
            putovanje.Location = lokacija;
            putovanje.Duration = trajanje;
            putovanje.ImageUrl = "https://brightspotincentivesevents.com/wp-content/uploads/2022/10/Night-Time-Zermatt_1-202210-FeIm-BL.jpg";
            putovanje.Clothing = new List<string> { "Belt", "T-Shirt", "Dress", "Jacket", "Sneakers", "Socks", "Shorts", "Hoodie", "Underwear", "Jeans", "Boots" };
            putovanje.Documents = new List<string> { "Passport", "Hotel Reservation", "Credit Card", "Visa", "Vaccination Certificates", "Medical Insurance Card", "Boarding Pass", "Drivers licence" };
            putovanje.Hygiene = new List<string> { "Shower gel", "Shampoo", "Toothpaste", "Face Wash", "Razor", "Makeup", "Deodorant", "Towels", "Tissues", "Brush", "Soap" };
            putovanje.Health = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler", "First Aid", "Hand Sanitizer", "Insect repellent", "Sunscreen", "Bandages", "Antibacterial Wipes" };
            putovanje.Gadgets = new List<string> { "Adapters", "Batteries", "Camera", "Chargers", "Laptop", "Kindle", "Headphones", "Flashlight", "Travel iron" };
            

            if (CampingCheckbox.IsChecked == true)
            {
                putovanje.Camping = new List<string> { "Tent", "Sleeping bags", "Camp chairs", "Sleeping pads", "Headlamps", "Matches", "Cooking utensils", "Insect repellent" };
            }
            if (BeachCheckbox.IsChecked == true)
            {
                putovanje.Beach = new List<string> { "Swimwear", "Towels", "Goggles", "Flip flops", "Swimming cap", "Sunglasses", "Bucket hat", "Sunscreen" };
            }

            Navigation.PushModalAsync(new DetailsPage(putovanje));

        }
    }

        String CalculateDuration()
    {
        TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;

        String duration = String.Format("{0} day{1}",
                                         timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        return duration;
    }
}