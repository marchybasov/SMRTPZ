using System.Collections.Generic;
namespace Lab4
{
    public class Road<T>
    {
        private List<Vehicle> carsInRoad = new List<Vehicle>();
        public int GetNumberOfHumans()
        {
            int totalHumanNumbers = 0;
            foreach (var vehicle in carsInRoad)
            {
                totalHumanNumbers += vehicle.OccupiedSeats;
            }
            return totalHumanNumbers;
        }
        public void AddCarToRoad(Vehicle vehicle)
        {
            carsInRoad.Add(vehicle);
        }
    }
}
