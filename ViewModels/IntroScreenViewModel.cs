using RMA_Tim6.Models;
using RMA_Tim6.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RMA_Tim6.ViewModels
{
    public class IntroScreenViewModel : BaseViewModel
    {

        #region Properties

        private string _buttonText = ">>";
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
        }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value, onChanged: (() =>
            {
                if (value == IntroScreens.Count - 1)
                {
                    ButtonText = "Get started";
                }
                else
                {
                    ButtonText = ">>";
                }
            }));
        }

        public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel>();
        #endregion

        public IntroScreenViewModel()
        {
            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Pack Easily",
                IntroDescription = "Lists for any type of activity",
                IntroImage = "wpicon2"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Save Time",
                IntroDescription = "Use Assistant to build lists automatically",
                IntroImage = "wpicon3"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Simple and Fast",
                IntroDescription = "Explore our favorite templates",
                IntroImage = "wpicon"
            });
        }


        public ICommand NextCommand => new Command(async () =>
        {
            if (Position >= IntroScreens.Count - 1)
            {
                await AppShell.Current.GoToAsync($"//{nameof(DashboardView)}");
            }
            else
            {
                Position += 1;
            }
        });


    }
}
