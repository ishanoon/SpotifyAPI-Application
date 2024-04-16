using SpotifyAPIIntegrationApplication.DTO;
using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Services
{
    public interface IAlbumService
    {
        Task<Albums> GetAlbums();
    }
}
