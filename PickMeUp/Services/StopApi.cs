using sitenames.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace sitenames.Services
{
    // Purpose of this class is to get data (all stops) from
    // https://www.trafiklab.se/api/sl-hallplatser-och-linjer-2


    public class StopApi
    {
        // GetAllStops
        public async Task<List<Site>> GetAllStopsAsync(string apikey)
        {
            var content = new List<Site>();
            HttpClient client = new HttpClient();

            string url = "http://api.sl.se/api2/LineData.json?key=" + apikey + "&model=SiteName";
            HttpResponseMessage response = await client.GetAsync(url);
            var responseObj = await response.Content.ReadAsJsonAsync<SiteResponse>();
            List <Site> sites = responseObj.ResponseData.Result;
            return sites;  
        }
    }
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
        {
            // http://nodogmablog.bryanhogan.net/2017/10/httpcontent-readasasync-with-net-core-2/
            // If you are used to using HttpContent.ReadAsAsync you might be surprised to learn that it is missing from .NET Core 2.
            // You can try adding Microsoft.AspNet.WebApi.Client but you might get warnings or errors.

            string json = await content.ReadAsStringAsync();
            T value = JsonConvert.DeserializeObject<T>(json);
            return value;
        }
    }
}
