namespace CurrencyExchange
{
    public class CurrencyExchange
    {
        private CurrencyDataRepository cdr;

        public CurrencyExchange()
        {
            cdr = new CurrencyDataRepository();
        }

        public decimal GetRate(DateTime date, string from_currency, string to_currency)
        {
            //return cdr.RateLookup(date, from_currency, to_currency);
            return 0.0m;
        }
    }
}
