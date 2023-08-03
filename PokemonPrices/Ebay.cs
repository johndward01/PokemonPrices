﻿namespace PokemonPrices;

public class Ebay
{
    public string currencyCode { get; set; }
    public string priceType { get; set; }
    public List<string> currenciesUsed { get; set; }
    public DateTime? lastUpdatedAt { get; set; }
    public int? periodSizeDays { get; set; }
    public int? volume { get; set; }
    public StdDev stdDev { get; set; }
    public MinPrice minPrice { get; set; }
    public FirstQuartile firstQuartile { get; set; }
    public Median median { get; set; }
    public Mean mean { get; set; }
    public ThirdQuartile thirdQuartile { get; set; }
    public MaxPrice maxPrice { get; set; }
}

