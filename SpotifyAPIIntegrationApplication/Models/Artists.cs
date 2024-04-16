using System.Text.Json.Serialization;

namespace SpotifyAPIIntegrationApplication.Models
{
    public class Artists
    {
        public string id { get; set; }
        public string? Name { get; set; }
        public string? popularity { get; set;}

        public string? type { get; set;}

        public string[] genres { get; set;}

        public Object? followers { get; set;} 

        [JsonPropertyName("uri")]
        public string? SpotifyUri { get; set; }
    }
}
