// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using GangOfFourDesignPatterns.AbstractFactory;
using GangOfFourDesignPatterns.Builder;
using GangOfFourDesignPatterns.Factory;
using GangOfFourDesignPatterns.Singleton;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter the value: ");

var input = Console.ReadLine();

switch (input){
    case "singleton":
        Logger.GetLogger?.Log("Welcome to Singleton!");
        break;
    case "lazy-singleton":
        LazyLogger.GetLogger.Log("Welcome to Singleton with Lazy Loading - ");
        break;
    case "factory":
        var file = new FileExtractionFactory().CreateFileExtraction(FileType.EXCEL);
        file.Extract("Extract file content in excel ");
        break;
    case "abstract-factory":
        IVehicleFactory hero = new HeroVehicleFactory();
        var heroClient = new VehicleClient(hero, "regular");
        Console.WriteLine($"{heroClient.GetBikeName()}");
        Console.WriteLine($"{heroClient.GetScooterName()}");

        IVehicleFactory honda = new HeroVehicleFactory();
        var hondaClient = new VehicleClient(honda, "sports");
        Console.WriteLine($"{hondaClient.GetBikeName()}");
        Console.WriteLine($"{hondaClient.GetScooterName()}");
        break;
    case "builder":
        IHouseBuilder houseBuilder = new HouseBuilder();
        var houseDirector = new HouseDirector(houseBuilder);
        houseDirector.ConstructHouse();
        Console.WriteLine(houseBuilder.GetHouse());
        break;
    default:
        throw new ValidationException("Invalid design patten type");
}

Console.ReadKey();