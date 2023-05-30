using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

const string fileStore = "save.txt";
string authToken;


if (File.Exists(fileStore))
{
    // Load agent token
    authToken = File.ReadAllText(fileStore);
}
else
{
    // Create agent and store the token
    Console.Write("No save found. Enter new agent symbol to register: ");
    var agentSymbol = Console.ReadLine();

    authToken = new DefaultApi().Register(new RegisterRequest(RegisterRequest.FactionEnum.COSMIC, agentSymbol)).Data
        .Token;

    File.WriteAllText(fileStore, authToken);
    Console.WriteLine("Registered. Let's go!");
}


// Authentication for all other requests
var config = new Configuration();
config.AccessToken = authToken;


Agent agent = new AgentsApi(config).GetMyAgent().Data;
Console.WriteLine("This is your agent:");
Console.WriteLine($"Agent: {agent.Symbol}, Credits: {agent.Credits}, HQ: {agent.Headquarters}");

Console.WriteLine();
Console.WriteLine("These are your ships:");
foreach (var ship in new FleetApi(config).GetMyShips().Data)
{
    Console.Write($"  Ship: ");
    Console.Write($"{ship.Symbol}");
    Console.WriteLine($" [{ship.Registration.Role}]");
    Console.WriteLine($"  Nav:");
    Console.WriteLine($"    Status: {ship.Nav.Status}");
    Console.WriteLine($"    waypoint: {ship.Nav.WaypointSymbol}");
    Console.WriteLine($"  Cargo: {ship.Cargo.Units}/{ship.Cargo.Capacity}");
    foreach (var item in ship.Cargo.Inventory)
    {
        Console.WriteLine($"    -- {item.Units}x {item.Name}");
    }

    Console.WriteLine($"  Fuel: {ship.Fuel.Current}/{ship.Fuel.Capacity}");
    Console.WriteLine();
}

Console.WriteLine("Have fun!");