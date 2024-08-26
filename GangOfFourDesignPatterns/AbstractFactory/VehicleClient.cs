using System;

namespace GangOfFourDesignPatterns.AbstractFactory
{
    public class VehicleClient
    {
        IBike bike;
        IScooter scooter;

        public VehicleClient(IVehicleFactory vehicleFactory, string type)
        {
            this.bike = vehicleFactory.GetBike(type);
            this.scooter = vehicleFactory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return this.bike.Name();
        }
        public string GetScooterName()
        {
            return this.scooter.Name();
        }
    }
}
