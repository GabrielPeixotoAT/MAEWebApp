using MAEWebApp.Models.ViewModels;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MAEWebApp.MAE_Api
{
    public class ApiRequest
    {
        public ApiRequest() 
        {
            
        }
        public static async Task<List<SubjectViewModel>> Get(string url)
        {
            HttpClient client = new HttpClient();
            //HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage response = await client.GetAsync(url);

            string data = await response.Content.ReadAsStringAsync();
            
            List<SubjectViewModel> subjectView = JsonSerializer.Deserialize<List<SubjectViewModel>>(data);

            return subjectView;
        }

        public static async Task Post(string url)
        {

        }
    }
}
