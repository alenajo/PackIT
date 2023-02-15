using RMA_Tim6.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RMA_Tim6.ViewModels;

namespace RMA_Tim6.ViewModels
{
public class HomePageViewModel : INotifyPropertyChanged
{
        public ObservableCollection<Putovanje> Putovanja { get; private set; } = new ObservableCollection<Putovanje>();

        public HomePageViewModel()
        {
            AddPutovanja();
        }

        void AddPutovanja()
        {
            Putovanja.Add(new Putovanje
            {
                Name = "Skiing trip",
                Location = "Zermatt, Switzerland",
                Category = "Winter",
                Duration = "10 days",
                ImageUrl = "https://brightspotincentivesevents.com/wp-content/uploads/2022/10/Night-Time-Zermatt_1-202210-FeIm-BL.jpg",
                IsFavorite = true,
                Description = "Winter holiday",
                Clothing = new List<string> { "Ski pants", "T-Shirt", "Boots", "Jeans" },
                Hygiene = new List<string> { "Body Wash", "Shampoo", "Toothpaste", "Face Wash" },
                Health = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler" },
                Documents = new List<string> { "Passport", "Cash", "Hotel Reservation", "Credit Card" },
                Gadgets = new List<string> { "Adapters", "Batteries", "Camera", "Charger" }
        });
            Putovanja.Add(new Putovanje
            {
                Name = "Camping Trip",
                Location = "Chitta Katha Lake, Pakistan",
                Category = "Camping",
                Duration = "3 days",
                ImageUrl = "https://preview.redd.it/7f0o1d5im0x61.jpg?width=640&crop=smart&auto=webp&v=enabled&s=32d7daa067a572555e829120949a8936b7bf78e9",
                IsFavorite = true,
                Description = "Adventure awaits",
                Clothing = new List<string> { "Jacket", "T-Shirt", "Boots", "Jeans" },
                Hygiene = new List<string> { "Body Wash", "Shampoo", "Toothpaste", "Face Wash" },
                Health = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler" },
                Documents = new List<string> { "Passport", "Cash", "Hotel Reservation", "Credit Card" },
                Gadgets = new List<string> { "Adapters", "Batteries", "Camera", "Charger" }
            });
            Putovanja.Add(new Putovanje
            {
                Name = "Summer vacation",
                Location = "Dubrovnik, Croatia",
                Category = "Summer",
                Duration = "7 days",
                ImageUrl = "https://www.croatiatravelco.com/wp-content/uploads/2016/11/dubrovnik_croatia.jpg",
                IsFavorite = true,
                Description = "Summer paradise",
                Clothing = new List<string> { "Swimsuit", "T-Shirt", "Boots", "Jeans" },
                Hygiene = new List<string> { "Body Wash", "Shampoo", "Toothpaste", "Face Wash" },
                Health = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler" },
                Documents = new List<string> { "Passport", "Cash", "Hotel Reservation", "Credit Card" },
                Gadgets = new List<string> { "Adapters", "Batteries", "Camera", "Charger" }
            });
            Putovanja.Add(new Putovanje
            {
                Name = "Trip to Paris",
                Location = "Paris, France",
                Category = "Road Trip",
                Duration = "2 days",
                ImageUrl = "https://i.pinimg.com/originals/de/d5/85/ded5852eba69ea4bafd6bfa1177e707b.jpg",
                IsFavorite = true,
                Description = "Weekend getaway",
                Clothing = new List<string> { "Dress", "T-Shirt", "Boots", "Jeans" },
                Hygiene = new List<string> { "Body Wash", "Shampoo", "Toothpaste", "Face Wash" },
                Health = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler" },
                Documents = new List<string> { "Passport", "Cash", "Hotel Reservation", "Credit Card" },
                Gadgets = new List<string> { "Adapters", "Batteries", "Camera", "Charger" }
            });
            Putovanja.Add(new Putovanje
            {
                Name = "Legal Conference",
                Location = "London, England",
                Category = "Business Trip",
                Duration = "2 days",
                ImageUrl = "https://london.com/wp-content/uploads/2019/03/london_001.jpg",
                IsFavorite = true,
                Description = "Solo trip",
                Clothing = new List<string> { "Shirt", "T-Shirt", "Boots", "Jeans" },
                Hygiene = new List<string> { "Body Wash", "Shampoo", "Toothpaste", "Face Wash" },
                Health = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler" },
                Documents = new List<string> { "Passport", "Cash", "Hotel Reservation", "Credit Card" },
                Gadgets = new List<string> { "Adapters", "Batteries", "Camera", "Charger" }
            });
            Putovanja.Add(new Putovanje
            {
                Name = "Aqua park",
                Location = "Berlin, Germany",
                Category = "Summer",
                Duration = "1 day",
                ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0b/8f/2f/b8/blick-auf-die-junior.jpg?w=1200&h=-1&s=1",
                IsFavorite = true,
                Description = "Family day",
                Clothing = new List<string> { "Swimsuit", "T-Shirt", "Boots", "Jeans" },
                Hygiene = new List<string> { "Body Wash", "Shampoo", "Toothpaste", "Face Wash" },
                Health = new List<string> { "Vitamins", "Medications", "Allergy pills", "Asthma Inhaler" },
                Documents = new List<string> { "Passport", "Cash", "Hotel Reservation", "Credit Card" },
                Gadgets = new List<string> { "Adapters", "Batteries", "Camera", "Charger" }
            });
        }



        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        }
}