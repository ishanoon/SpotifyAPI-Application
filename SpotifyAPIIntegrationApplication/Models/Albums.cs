using Newtonsoft.Json;

namespace SpotifyAPIIntegrationApplication.Models
{
    public class Albums
    {
        public string id { get; set; }
        public string? name { get; set; }
        public string? album_type { get; set; }
        public int total_tracks { get; set; }

        public List<string>? available_markets { get; set; }

        
        //public Object? tracks { get; set; }
        public string? release_date { get; set; }

        public List<SimplifiedArtististObject> artists { get; set; }

        public string[]? genres { get; set; }
        public string? label { get; set;}
        public int popularity { get; set;}

    }
}
