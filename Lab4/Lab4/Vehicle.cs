using System;
using System.Collections.Generic;

namespace Lab4
{

     public abstract class Vehicle
    {
       
        protected Type _allowedPassenger;
        public Type AllowedPassenger
        {
            get { return this._allowedPassenger; }
        }
        public int SeatingCapacity { get; set; }
        public int OccupiedSeats { get; set; }
        protected Vehicle(int seatingCapacity, int occupiedSeats)
        {
            SeatingCapacity = seatingCapacity;
            OccupiedSeats = occupiedSeats;
            PassengerIDs = new List<int>();
        }
        public List<int> PassengerIDs { get; }
       
    }
}
