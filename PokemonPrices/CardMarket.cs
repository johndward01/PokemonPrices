namespace PokemonPrices;

public class CardMarket
{
    public string currencyCode { get; set; }
    public string currencyCodeUsed { get; set; }
    public DateTime lastUpdatedAt { get; set; }
    public LowPrice lowPrice { get; set; }
    public AverageSellPrice averageSellPrice { get; set; }
    public TrendPrice trendPrice { get; set; }
    public AverageOneDay averageOneDay { get; set; }
    public AverageSevenDay averageSevenDay { get; set; }
    public AverageThirtyDay averageThirtyDay { get; set; }
}

