using MVVM.Commands;
using MVVM.Models;
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
        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "SingletoSean", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 2), "Joe", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 4), "Mary", DateTime.Now, DateTime.Now)));

        }

    }
}
