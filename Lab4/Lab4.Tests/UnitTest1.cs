using System;
using Xunit;
using Lab4;
namespace Lab4.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Can__CheckPassenger()
        {
            FireTrack fireTrack = new FireTrack(15,10);
            Taxi taxi = new Taxi(4,3);
            IHuman fireMan = new FireFighter(1);
            IHuman policeman = new PoliceOfficer(2);

            VehicleHandler<Vehicle> handler = new VehicleHandler<Vehicle>();
            

            Assert.True(handler.CheckPassenger(fireTrack, fireMan));
            Assert.False(handler.CheckPassenger(fireTrack,policeman));
            Assert.True(handler.CheckPassenger(taxi,fireMan));
            Assert.True(handler.CheckPassenger(taxi, policeman));
        }

        [Fact]
        public void Can_CheckIn()
        {
            Bus bus = new Bus(35,33);
            IHuman fireman = new FireFighter(1);
            IHuman fireman2 = new FireFighter(2);
            IHuman policeman = new PoliceOfficer(3);

            VehicleHandler<Vehicle> helper = new VehicleHandler<Vehicle>();
            helper.CheckIn(bus,fireman);
            helper.CheckIn(bus,fireman2);
            Assert.Equal(35,bus.OccupiedSeats);
            Assert.Throws<InvalidOperationException>(() => helper.CheckIn(bus, policeman));


        }

        [Fact]
        public void Can_Checkout()
        {
            Bus bus = new Bus(35, 31);
            IHuman fireman = new FireFighter(1);
            IHuman fireman2 = new FireFighter(2);
            IHuman policeman = new PoliceOfficer(3);
            VehicleHandler<Vehicle> helper = new VehicleHandler<Vehicle>();
            helper.CheckIn(bus, fireman);
            helper.CheckIn(bus, fireman2);
            helper.CheckIn(bus, policeman);
            Assert.Equal(34, bus.OccupiedSeats);
            helper.CheckOut(bus, fireman2);
            Assert.Equal(33, bus.OccupiedSeats);
            Assert.Throws<InvalidOperationException>(() => helper.CheckOut(bus, fireman2));


        }
        [Fact]
        public void Can_CountHumanOnRoad()
        {
            Road<Vehicle> road = new Road<Vehicle>();

            road.AddCarToRoad(new FireTrack(15, 10));
            road.AddCarToRoad(new Taxi(4, 3));
            road.AddCarToRoad(new PoliceCar(4, 1));
            road.AddCarToRoad(new Bus(45,39));
            

            Assert.Equal(53,road.GetNumberOfHumans());

        }
    }
}
