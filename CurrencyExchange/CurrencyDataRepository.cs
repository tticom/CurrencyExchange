using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyExchange
{
    internal class CurrencyDataRepository
    {
        private string Folder { get; set; } 
        private string Filename { get; set; }
        private CurrenciesData? CurrencyData { get; set; }

        internal CurrencyDataRepository(string folder = "c:\\temp\\CurrencyExchange", string filename = "eurofxref-hist-90d.json")
        {
            Folder = folder;
            Filename = filename;
            Load();
        }

        private void Load()
        {
            try
            {
                var path = Path.GetFullPath(Path.Combine(Folder, Filename));
                if (!File.Exists(path))
                    throw new FileNotFoundException("No Generation Report Data, {Filename} could not befound");

                var json = File.ReadAllText(path);
                dynamic jToken = JToken.Parse(json);
                var props = ((object)jToken).GetType().GetProperties();
                //CurrenciesData data = 
                CurrencyData = JsonConvert.DeserializeObject<CurrenciesData>(json);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message + " " + fnfe.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
