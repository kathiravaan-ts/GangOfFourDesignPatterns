using System;
using System.ComponentModel.DataAnnotations;

namespace GangOfFourDesignPatterns.AbstractFactory
{
    public interface IVehicleFactory 
    {
        IBike GetBike(string bike);
        IScooter GetScooter(string scooter);
    }
    public class HondaVehicleFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "sports":
                    return new SportsBike();
                case "regular":
                    return new RegularBike();
                default:
                    throw new ValidationException("Invalid Bike type");
            }
        }

        public IScooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "sports":
                    return new Scooty();
                case "regular":
                    return new RegularScooter();
                default:
                    throw new ValidationException("Invalid Scooter type");
            }
        }
    }

    public class HeroVehicleFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "sports":
                    return new SportsBike();
                case "regular":
                    return new RegularBike();
                default:
                    throw new ValidationException("Invalid Bike type");
            }
        }

        public IScooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "sports":
                    return new Scooty();
                case "regular":
                    return new RegularScooter();
                default:
                    throw new ValidationException("Invalid Scooter type");
            }
        }
    }
}