// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Text;
using GangOfFourDesignPatterns.AbstractFactory;
using GangOfFourDesignPatterns.Builder;
using GangOfFourDesignPatterns.Factory;
using GangOfFourDesignPatterns.Mediator;
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
    case "http-builder":
        var request = new HttpRequestBuilder()
            .WithMethod(HttpMethod.Post)
            .WithUri(new Uri("https://api.example.com/items"))
            .WithContent(new StringContent("{\"name\":\"sampleItem\"}", Encoding.UTF8, "application/json"))
            .WithHeader("Authorization", "Bearer my_token")
            .Build();
        // You can now use this request with HttpClient to send the actual request.
        using (var client = new HttpClient())
        {
            var response = client.SendAsync(request).Result;
            Console.WriteLine(response.StatusCode);
        }
        break;
    case "mediator":
        IChatMediator _mediator = new ChatMediator();
        var user1 = new ChatUser("Kathir");
        var user2 = new ChatUser("nivetha");
        var user3 = new ChatUser("athiyan");

        _mediator.RegisterUser(user1);
        _mediator.RegisterUser(user2);
        _mediator.RegisterUser(user3);
        user2.SendMessage("Hello! Welcome");
        user1.SendMessage("How are you?");        
        break;
    default:
        throw new ValidationException("Invalid design patten type");
}

Console.ReadKey();