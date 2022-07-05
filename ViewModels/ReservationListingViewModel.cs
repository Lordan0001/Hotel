using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        public ICommand MakeReservationCommand { get; }

        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
        }
        //8:51
    }
}
