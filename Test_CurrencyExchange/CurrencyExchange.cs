using System;

namespace Test_CurrencyExchange
{
    public class CurrencyExchangeTests
    {
        [Fact]
        public void test_non_base_currency_exchange_is_correct()
        {
            decimal correct_rate = 1.2870493690602498m;
            Assert.Equal(correct_rate, CurrencyExchange.CurrencyExchange.rate(new DateTime(2018, 11, 22), "GBP", "USD"));
        }

        [Fact]
        void test_base_currency_exchange_is_correct()
        {
            decimal correct_rate = 0.007763975155279502m;
            Assert.Equal(correct_rate, CurrencyExchange.CurrencyExchange.rate(new DateTime(2018, 11, 22), "JPY", "EUR"));
        }
    }
}