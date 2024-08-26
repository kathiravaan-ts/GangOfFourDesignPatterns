using System;

namespace GangOfFourDesignPatterns.Builder
{
    //Actual Product
    public class House  
    {
        public string Walls{ get; set; } = null!;
        public string Doors { get; set; } = null!;
        public string Roof { get; set; } = null!;
        public string Windows { get; set; } = null!;

        public override string ToString()
        {
            return $"House built with Walls: {Walls}, Doors: {Doors}, Roof: {Roof}, Windows: {Windows}";
        }
    }

    // Builder interface to construct the product
    public interface IHouseBuilder 
    {
        void BuildWalls();
        void BuildDoors();
        void BuildRoof();
        void BuildWindows();
        House GetHouse();        
    }

    //Actual builder through which object has been created.
    public class HouseBuilder : IHouseBuilder
    {
        private readonly House _house = new House();
        public void BuildDoors()
        {
            _house.Doors = "Sandal Woods";
        }

        public void BuildRoof()
        {
            _house.Roof = "Concrete";
        }

        public void BuildWalls()
        {
            _house.Walls = " Red bricks";
        }

        public void BuildWindows()
        {
           _house.Windows = "Wooden and Glass";
        }

        public House GetHouse() //Returns the built product to the consumers
        {
           return _house;
        }
    }


   //Responsible for choosing the properties need for the final built house and directs the builder to create a house or product.
    public class HouseDirector 
    {
        private readonly IHouseBuilder _houseBuilder;
        public HouseDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void ConstructHouse()
        {
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildWindows();
            _houseBuilder.BuildDoors();

        }
    }
}
