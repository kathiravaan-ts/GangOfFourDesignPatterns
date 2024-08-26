// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
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
    default:
        throw new ValidationException("Invalid design patten type");
}

Console.ReadKey();