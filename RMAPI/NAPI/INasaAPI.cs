using Microsoft.AspNetCore.ResponseCompression;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RMAPI.NasaAPI
{
    public interface INasaApi
    {
        Task<RoverResponse> GetRoverResponse(int sol, string camera);
    }

    public class Photo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("img_src")]
        public string ImgSrc{ get; set; }
        public Camera Camera { get; set; }

        [JsonPropertyName("earth_date")]
        public string EarthDate { get; set; }

    }

    public class Camera
    {
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
    }

    public class RoverResponse
    {
        [JsonPropertyName("photos")]
        public List<Photo> Photos { get; set; }
    }

    
    

}
