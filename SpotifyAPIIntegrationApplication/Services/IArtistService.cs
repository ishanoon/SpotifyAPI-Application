using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artists>> GetArtists();

        Task<Artists> GetArtist(string Name);
    }
}
