using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoPopUp
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigation navigation;

        public MainPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }

        public ICommand OverlayCommand =>
            new Command(() =>
            {
                Visibility = true;
            });
        public ICommand PopUpButton =>
            new Command(() =>
            {
                Visibility = false;
            });

        private bool visibility = false;
        public bool Visibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                OnPropertyChanged("Visibility");
            }
        }

    }
}
