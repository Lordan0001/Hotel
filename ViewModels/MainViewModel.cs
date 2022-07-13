using MVVM.Models;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }
        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}
