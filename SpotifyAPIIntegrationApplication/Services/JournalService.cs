using AutoMapper;
using RestSharp;
using SpotifyAPIIntegrationApplication.Models;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace SpotifyAPIIntegrationApplication.Services
{
    public class JournalService : IJournalServices
    {
        private readonly string? BaseUri = "http://export.arxiv.org/api/query?search_query=all:electrony";

        public async Task<string> GetJournals()
        {
            var restClient = new RestClient(BaseUri);
            var restRequest = new RestRequest();

            var response = await restClient.GetAsync(restRequest);

            return response.Content.ToString();
 

    }

        public Task<IEnumerable<Journal>> GetAllJournalsByAuthor(string AuthorName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Journal>> GetAllJournalsWithInstitutionAffiliation(string Affiliation)
        {
            throw new NotImplementedException();
        }
    }
}
