using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemAdmin.Services
{
    public static class ApiService
    {
        public static string baseUrl =
            "http://localhost:5194/api/";

        public static async Task<string> Post(
            string endpoint,
            object data)
        {
            using (HttpClient client = new HttpClient())
            {
                var json =
                    JsonConvert.SerializeObject(data);

                var content =
                    new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json"
                    );

                HttpResponseMessage response =
                    await client.PostAsync(
                        baseUrl + endpoint,
                        content
                    );

                return await response
                    .Content
                    .ReadAsStringAsync();
            }
        }

        // ADD NI
        public static async Task<string> Get(
            string endpoint)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response =
                    await client.GetAsync(
                        baseUrl + endpoint
                    );

                return await response
                    .Content
                    .ReadAsStringAsync();
            }
        }
    }
}