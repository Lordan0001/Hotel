﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class RoomID
    {
        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public int FloorNumber { get; }
        public int RoomNumber { get; }


        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID && FloorNumber == roomID.FloorNumber && RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);   
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }
    }
}