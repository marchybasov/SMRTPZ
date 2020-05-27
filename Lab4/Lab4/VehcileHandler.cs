using System;
namespace Lab4
{
    public class VehicleHandler<T> where T : Vehicle
    {
        public void CheckIn(T vehicle, IHuman passenger)
        {
            if (CheckPassenger(vehicle, passenger))
            {
                if (vehicle.OccupiedSeats < vehicle.SeatingCapacity)
                {
                    vehicle.OccupiedSeats++;
                    vehicle.PassengerIDs.Add(passenger.Id);

                }
                else
                {
                    throw new InvalidOperationException($"There are no empty seats in this vehicle");
                }
            }
        }

        public void CheckOut(T vehicle, IHuman passenger)
        {
            if (vehicle.PassengerIDs.Contains(passenger.Id))
            {
                vehicle.OccupiedSeats--;
                vehicle.PassengerIDs.Remove(passenger.Id);
            }
            else { throw new InvalidOperationException($"There is no passenger with this ID in this vehicle"); }
        }

        public bool CheckPassenger(T vehicle, IHuman passenger)
        {
            if (vehicle.AllowedPassenger == null || vehicle.AllowedPassenger == passenger.GetType())
            {
                return true;
            }

            return false;
        }


    }
}
