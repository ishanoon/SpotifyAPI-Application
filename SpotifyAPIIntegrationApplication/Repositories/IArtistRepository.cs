using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Repositories
{
    public interface IArtistRepository
    {
        Task<Artists> GetArtist(string Name);
    }
}
