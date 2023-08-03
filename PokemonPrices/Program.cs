using Newtonsoft.Json;
using PokemonPrices;
using RestSharp;

var client = new RestClient("https://pokemon-tcg-card-prices.p.rapidapi.com/card?setId=33ee55f4-30d0-4900-850f-36a351fb9719&set=vivid-voltage&series=sword-and-shield");
var request = new RestRequest();
request.AddHeader("X-RapidAPI-Key", "c69daab450msh8d841055c912583p1f9399jsnb02781781271");
request.AddHeader("X-RapidAPI-Host", "pokemon-tcg-card-prices.p.rapidapi.com");
var response = client.Execute(request).Content;

//Console.WriteLine(response);

var root = JsonConvert.DeserializeObject<Root>(response);

foreach (var item in root.results)
{
    Console.WriteLine($"Name: {item.name}");
    Console.WriteLine($"Variant: {item.variant}");
    Console.WriteLine($"High Sold Price: {item.highSoldPrice?.amountInMinorUnits}");
    Console.WriteLine($"Low Sold Price: {item.lowSoldPrice?.amountInMinorUnits}");
    Console.WriteLine($"Listing Price: {item.listingPrice?.amountInMinorUnits}");
    Console.WriteLine($"Rarity: {item.rarity}");
    Console.WriteLine();
}

// Console.WriteLine($"{card.name}");
// Console.WriteLine($"{card.variant}");
// Console.WriteLine($"{card.highSoldPrice}");
// Console.WriteLine($"{card.lowSoldPrice}");
// Console.WriteLine($"{card.listingPrice}");
// Console.WriteLine($"{card.rarity}");

