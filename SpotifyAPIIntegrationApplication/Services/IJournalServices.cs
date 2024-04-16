using SpotifyAPIIntegrationApplication.Models;

namespace SpotifyAPIIntegrationApplication.Services
{
    public interface IJournalServices
    {
        Task<string> GetJournals();

        Task<IEnumerable<Journal>> GetAllJournalsByAuthor(string AuthorName);

        Task<IEnumerable<Journal>> GetAllJournalsWithInstitutionAffiliation(string Affiliation);
    }
}
