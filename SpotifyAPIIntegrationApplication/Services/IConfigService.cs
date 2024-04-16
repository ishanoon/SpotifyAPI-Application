namespace SpotifyAPIIntegrationApplication.Services
{
    public interface IConfigService
    {
        Task<string> GetToken();
    }
}
