using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Reservation
    {
        public string Username { get; }
        public RoomID RoomID { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public Reservation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            StartTime = startTime;
            EndTime = endTime;
            Username = username;
        }

        public TimeSpan Length => EndTime.Subtract(StartTime);
  

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
