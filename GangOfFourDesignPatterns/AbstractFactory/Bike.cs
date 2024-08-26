using System;

namespace GangOfFourDesignPatterns.AbstractFactory
{
    public interface IBike 
    {
        string Name();
    }
    public class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike has been Created!";
        }
    }

    public class RegularBike : IBike
    {
        public string Name()
        {
            return "Regular Bike has been Created!";
        }
    }
}
