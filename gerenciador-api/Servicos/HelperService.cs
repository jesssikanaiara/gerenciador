using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GerenciadorApi.Servicos
{
    public class HelperService
    {
        //static string URL_API = "https://homologacao.focusnfe.com.br/v2";
        static string URL_API = "https://api.focusnfe.com.br/v2";
        //static string TOKEN = "AtM793AsiiGOxuazzRLSomnF35WBLVP3";//hml
        static string TOKEN = "cj9eWhyUbXIW2T3fhLiPlrVDqQLsEmf8";//prod


        public static async Task<(T result, HttpStatusCode status)> Post<T>(object param, string url)
        {
            HttpClient client = getClient(ref url);

            var content = new StringContent(JsonConvert.SerializeObject(param,Newtonsoft.Json.Formatting.None, 
                            new JsonSerializerSettings { 
                                NullValueHandling = NullValueHandling.Ignore
                            }), 
                            Encoding.UTF8,
                            "application/json");

            var httpResult = await client.PostAsync(url, content);

            if (httpResult.StatusCode == HttpStatusCode.Created || httpResult.StatusCode == HttpStatusCode.OK)
            {
                var resultJson = await httpResult.Content.ReadAsStringAsync();

                try
                {
                    var tokenResult = JsonConvert.DeserializeObject<T>(resultJson);
                    return (tokenResult, httpResult.StatusCode);
                }
                catch (System.Exception)
                {
                    return (default(T), httpResult.StatusCode);
                }
            }
            else
            {
                string resultJson = await httpResult.Content.ReadAsStringAsync();
                return (default(T), httpResult.StatusCode);
            }
        }

        public static async Task<(T result, HttpStatusCode status)> Get<T>(string url)
        {
            HttpClient client = new HttpClient();            

            var urlFinal = $"{URL_API}/{url}?token={TOKEN}";
            var httpResult = await client.GetAsync(urlFinal);

            if (httpResult.StatusCode == HttpStatusCode.OK)
            {
                var resultJson = await httpResult.Content.ReadAsStringAsync();

                try
                {
                    var tokenResult = JsonConvert.DeserializeObject<T>(resultJson);
                    return (tokenResult, httpResult.StatusCode);
                }
                catch (System.Exception)
                {
                    return (default(T), httpResult.StatusCode);
                }
            }
            else
            {
                string resultJson = await httpResult.Content.ReadAsStringAsync();
                return (default(T), httpResult.StatusCode);
            }
        }

        private static HttpClient getClient(ref string url)
        {
            if(url.Contains("?"))
                url += "&";
            else
                url += "?";

            url += $"token={TOKEN}";
            
            var baseAddress = new Uri(URL_API);

            var client = new HttpClient() { BaseAddress = baseAddress };
            return client;
        }
    }
}