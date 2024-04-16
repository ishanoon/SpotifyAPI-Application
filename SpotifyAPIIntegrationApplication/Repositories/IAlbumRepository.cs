using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Repositories
{
    public interface IAlbumRepository
    {
        Task<IEnumerable<Albums>> GetAlbums();

        Task<Albums> GetAlbum(string Name);
    }
}
