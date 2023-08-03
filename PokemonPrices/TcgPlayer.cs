namespace PokemonPrices;

public class TcgPlayer
{
    public string currencyCode { get; set; }
    public string currencyCodeUsed { get; set; }
    public DateTime lastUpdatedAt { get; set; }
    public Low low { get; set; }
    public Mid mid { get; set; }
    public High high { get; set; }
    public DirectLow directLow { get; set; }
    public Market market { get; set; }
}

