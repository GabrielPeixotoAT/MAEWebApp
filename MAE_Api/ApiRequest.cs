using MAEWebApp.Models.ViewModels;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MAEWebApp.MAE_Api
{
    public class ApiRequest<T>
    {
        public ApiRequest() 
        {
            
        }

        public static async Task<T> Get(string url)
        {
            HttpClient client = new HttpClient();
            //HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage response = await client.GetAsync(url);

            string data = await response.Content.ReadAsStringAsync();
            
            T objects = JsonSerializer.Deserialize<T>(data);

            return objects;
        }

        public static async Task<T> Post(string url, T obj)
        {
            return await Get(url);
        }
    }
}
