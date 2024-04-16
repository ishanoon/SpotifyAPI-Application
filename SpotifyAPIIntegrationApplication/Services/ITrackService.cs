using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Services
{
    public interface ITrackService
    {
        Task<Tracks> GetTrack(string Name);
    }
}
