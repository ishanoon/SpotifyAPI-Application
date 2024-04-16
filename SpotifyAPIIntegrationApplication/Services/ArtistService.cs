using RestSharp;
using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Services
{
    public class ArtistService : IArtistService
    {
        RestClient client = new RestClient();
        public Task<Artists> GetArtist(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Artists>> GetArtists()
        {
            throw new NotImplementedException();
        }
    }
}
