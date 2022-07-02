using MVVM.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class ReservationBook
    {

        private readonly List<Reservation> _reservations;


        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(x => x.Username == username);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach(Reservation existiningReservation in _reservations)
            {
                if (existiningReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existiningReservation, reservation);
                }
               
            }


            _reservations.Add(reservation);
        }
         
    }
}
