using System;

namespace Lab4
{
    public class PoliceCar : Car
    {

        public PoliceCar(int seatingCapacity, int occupiedSeats) : base(seatingCapacity, occupiedSeats)
        {
            //_allowedPassenger = new PoliceOfficer();
            _allowedPassenger = typeof(PoliceOfficer);
            
        }
    }
}
