using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuillardLouennApp
{
    public class APICollecteur
    {
        private readonly HttpClient _client;

        public APICollecteur()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://api.sampleapis.com/coffee/hot")
            };
        }

        public async Task<string> GetAsync(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task AfficherDonneesAsync(string endpoint)
        {
            var donnees = await GetAsync(endpoint);
            Console.WriteLine(donnees);
        }
        
        
    }
}