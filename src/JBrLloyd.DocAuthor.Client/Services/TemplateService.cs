using System.Net.Http;
using System.Threading.Tasks;

namespace JBrLloyd.DocAuthor.Client.Services
{
    public class TemplateService
    {
        public HttpClient _httpClient;

        public TemplateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDefaultTemplate()
        {
            return await _httpClient.GetStringAsync("https://mockbin.org/bin/d63d6c98-9de6-4b17-8d9f-b9124dd1a306");
        }
    }
}
