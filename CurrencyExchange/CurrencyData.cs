namespace CurrencyExchange
{
    internal class CurrenciesData
    {
        List<ICurrencyData>? currencies { get; set; }
    }

    internal interface ICurrencyData
    {
        DateTime? Date { get; set; }
        List<ICurrencyData> CurrencyPricePairs { get; set; }
    }

    internal class CurrencyData
    {
        public DateTime Date { get; set; }
        public List<ICurrencyPrice>? CurrencyPricePairs { get; set; }
    }

    internal interface ICurrencyPrice
    {
        string? currency { get; set; }
        string? price { get; set; }
    }

    internal class CurrencyPrice : ICurrencyPrice
    {
        public string? currency { get; set; }
        public string? price { get; set; }
    }
}
