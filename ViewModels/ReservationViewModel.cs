using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        public readonly Reservation _reservation;
        public string Username => _reservation.Username;
        public string RoomID => _reservation.RoomID?.ToString();
        public string StartDate => _reservation.StartTime.ToString("d");
        public string EndDate => _reservation.EndTime.ToString("d");


        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }

    }
}
