// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
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
    default:
        throw new ValidationException("Invalid design patten type");
}

Console.ReadKey();