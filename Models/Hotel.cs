using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();

        }

        /// <summary>
        /// Get the reservations for a user.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>The reservations fo user.</returns>

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationBook.GetReservationsForUser(username);   
        }
        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation"></param>
        /// <exception cref="ReservationConflictException"

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }




    }
}
