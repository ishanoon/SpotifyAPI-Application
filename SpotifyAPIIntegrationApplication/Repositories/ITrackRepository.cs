using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Repositories
{
    public interface ITrackRepository
    {
        Task<Tracks> GetTrack(string Name);
    }
}
