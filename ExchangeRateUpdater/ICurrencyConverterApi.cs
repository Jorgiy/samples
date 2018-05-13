using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Refit;

namespace ExchangeRateUpdater
{
    public interface ICurrencyConverterApi
    {
        // There are several good api which are better than some bank's api, but this was free and in real project it 
        // will be better to pay for such api (which provide real rates from EU banks) that use bank different bank APIs
        // UPD : JObject is response model because this API has different fields' names for each corresponding currency 
        [Get("/api/v5/convert")]
        Task<JObject> GetExchangeRate(GetExchangeRateRequest request);
    }
}