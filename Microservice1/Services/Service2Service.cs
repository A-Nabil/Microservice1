using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Microservice1.Services
{
    public class Service2Service : IService2Service
    {
        HttpClient _client { get; }

        public Service2Service(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<string>> getValuesfromService2()
        {
            string url = "http://microservice2-service/api/data";

            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await _client.SendAsync(requestMessage);


            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            var resultResponse = JsonSerializer.Deserialize<List<string>>(responseBody);

            return resultResponse;
        }
    }
}
