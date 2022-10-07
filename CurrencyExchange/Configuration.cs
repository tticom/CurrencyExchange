using System.Configuration;

namespace CurrencyExchange
{
    public static class Configuration
    {
        public static string InputFolder => ConfigurationManager.AppSettings["InputFolder"] ?? "";
        public static string Filename => ConfigurationManager.AppSettings["Filename"] ?? "";
    }
}
