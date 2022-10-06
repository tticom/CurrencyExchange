namespace Test_CurrencyExchange
{
    public class CurrencyExchange
    {
        [Fact]
        public void test_non_base_currency_exchange_is_correct()
        {
            var correct_rate = 1.2870493690602498;
            Assert.Equal(correct_rate, CurrencyExchange.rate(Date.new(2018, 11, 22), "GBP", "USD"));
        }

        [Fact]
        void test_base_currency_exchange_is_correct()
        {
            var correct_rate = 0.007763975155279502;
            Assert.Equal(correct_rate, CurrencyExchange.rate(Date.new(2018, 11, 22), "JPY", "EUR"));
        }
    }
}