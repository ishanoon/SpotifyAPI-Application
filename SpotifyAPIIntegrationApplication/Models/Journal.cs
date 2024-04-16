namespace SpotifyAPIIntegrationApplication.Models
{
    public class Journal
    {
        public string? Id { get; set; }

        public string? Title { get; set; }
        
        public List<string>? Authors { get; set; }
        /**
        public DateOnly PulishedOn { get; set; }

        public DateOnly Updated { get; set; }
        **/
        public List<string>? Categories { get; set; }
    }
}
