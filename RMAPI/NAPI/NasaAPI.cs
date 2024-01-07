using RMAPI.NasaAPI;
using System.Text.Json;

namespace RMAPI.NAPI
{
    public class NasaApi : INasaApi
    {

        private readonly HttpClient _httpClient;

        public NasaApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<RoverResponse> GetRoverResponse(int sol, string camera)
        {
            var response = await _httpClient.GetAsync($"https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol={sol}&camera={camera}&api_key=DEMO_KEY");
            return await response.Content.ReadFromJsonAsync<RoverResponse>();
        }
    }

}
