using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DiscoveryWPF
{
    public class QnaService
    {
        public async static Task<string> GetAnswer(string question)
        {
            string endpoint_host = "https://discoveryqna.azurewebsites.net/qnamaker";
            //var uri = endpoint_host + endpointService + baseRoute + "/" + kbid + "/generateAnswer";
            var uri = endpoint_host + "/knowledgebases/3411861a-c73c-49e5-9d2e-9d50e68c1be4/generateAnswer";

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(uri);
                request.Content = new StringContent("{question:'" + question + "'}", Encoding.UTF8, "application/json");

                // NOTE: The value of the header contains the string/text 'EndpointKey ' with the trailing space
                request.Headers.Add("Authorization", "EndpointKey " + "3a227369-2646-47ff-9af2-98ab8eae446c");

                var response = await client.SendAsync(request);
                var responseBody = response.Content.ReadAsStringAsync().Result;
                //Console.WriteLine(PrettyPrint(responseBody));
                return responseBody;
            }
        }
    }
}
