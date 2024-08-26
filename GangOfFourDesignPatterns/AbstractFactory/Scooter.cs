using System;

namespace GangOfFourDesignPatterns.AbstractFactory
{
    public interface IScooter 
    {
        string Name();
    }
    public class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter has been Created!";
        }
    }
    public class Scooty : IScooter
    {
        public string Name()
        {
            return "Scooty has been Created!";
        }
    }
}
