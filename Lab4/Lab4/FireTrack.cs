using System;
using System.Dynamic;

namespace Lab4
{
    public class FireTrack : Car
    {
       
        public FireTrack(int seatingCapacity, int occupiedSeats) : base(seatingCapacity, occupiedSeats)
        {
           _allowedPassenger =  typeof(FireFighter);
        }

    }
}
