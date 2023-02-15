using Android.Content.Res;
using AndroidX.ConstraintLayout.Core.Parser;
using RMA_Tim6.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMA_Tim6.ViewModels
{
    public class GroupsViewModel
    {
        public ObservableCollection<Grupa> Grupe { get; private set; } = new ObservableCollection<Grupa>();

        public GroupsViewModel()
        {
            AddGrupe();
        }
        public void AddGrupe()
        {
            Grupe.Add(new Grupa
            {
                Id = 1,
                Name = "Documents",
                Items = new List<string> { "Passport", "Hotel Reservation", "Credit Card", "Visa",  "Vaccination Certificates", "Medical Insurance Card", "Boarding Pass", "Drivers licence" }
            });
            Grupe.Add(new Grupa
            {
                Id = 2,
                Name = "Clothing",
                Items = new List<string> { "Belt", "T-Shirt", "Dress", "Jacket", "Sneakers", "Socks", "Shorts" , "Hoodie", "Underwear", "Jeans", "Boots" }
            });
            Grupe.Add(new Grupa
            {
                Id = 3,
                Name = "Hygiene",
                Items = new List<string> { "Shower gel", "Shampoo", "Toothpaste", "Face Wash", "Razor", "Makeup", "Deodorant", "Towels", "Tissues", "Brush", "Soap" }
            });
            Grupe.Add(new Grupa
            {
                Id = 4,
                Name = "Health",
                Items = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler", "First Aid", "Hand Sanitizer", "Insect repellent", "Sunscreen", "Bandages", "Antibacterial Wipes" }
            });

            Grupe.Add(new Grupa
            {
                Id = 5,
                Name = "Gadgets",
                Items = new List<string> { "Adapters", "Batteries", "Camera", "Chargers", "Laptop", "Kindle", "Headphones", "Flashlight", "Travel iron" }
            });


            Grupe.Add(new Grupa
            {
                Id=6,
                Name="Hiking",
                Items = new List<string> { "Backpack", "Hiking shoes", "Food and water" ,"Map", "Compass", "First-aid kit" ,"Knife or multi-tool" }
            });

            Grupe.Add(new Grupa
            {
                Id = 7,
                Name = "Gym",
                Items = new List<string> { "Gym bag", "Water bottle", "Earbuds", "Gym towel", "Gym shoes", "Workout clothes", "Socks", "Headband", "Gym gloves" }
            });

            Grupe.Add(new Grupa
            {
                Id = 8,
                Name = "Skiing",
                Items = new List<string> { "Snowsuit", "Sweaters", "Gloves", "Winter hat", "Skis and ski poles", "Helmet", "Ski goggles", "Boots", "Neck gaiter" }
            });

            Grupe.Add(new Grupa
            {
                Id = 9,
                Name = "Beach",
                Items = new List<string> { "Swimwear", "Towels", "Goggles", "Flip flops", "Swimming cap", "Sunglasses", "Bucket hat", "Sunscreen" }
            });

            Grupe.Add(new Grupa
            {
                Id = 10,
                Name = "Camping",
                Items = new List<string> { "Tent", "Sleeping bags", "Camp chairs", "Sleeping pads", "Headlamps", "Matches", "Cooking utensils", "Insect repellent" }
            });

            Grupe.Add(new Grupa
            {
                Id = 11,
                Name = "Business",
                Items = new List<string> { "Travel documents", "Laptop", "Phone", "Office supplies", "Business card", "Notebook", "Pens", "Headphones" }
            });

        }
    }
}
