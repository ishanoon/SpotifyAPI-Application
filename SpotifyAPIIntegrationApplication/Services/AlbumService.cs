using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;
using SpotifyAPIIntegrationApplication.DTO;
using SpotifyAPIIntegrationApplication.Models;
using System.Text.Json;

namespace SpotifyAPIIntegrationApplication.Services
{
    public class AlbumService : IAlbumService
    {
        private const string BaseUrl = "https://api.spotify.com/v1/";
        private const string URLParameter = "";
        private const string clientId = "";
        private const string clientSecret = "";

        public string? getToken()
        {
            var client = new RestClient("https://accounts.spotify.com/api/token");
            RestRequest request = new RestRequest("", Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/x-www-form-urlencoded");
            /**
            request.AddParameter("application/x-www-form-urlencoded",
               $"grant_type=client_credentials&client_id={clientId}&client_secret={clientSecret}",
               ParameterType.RequestBody);
            **/
            request.AddParameter("client_id", clientId);
            request.AddParameter("client_secret", clientSecret);
            request.AddParameter("grant_type", "client_credentials");

            var response = client.Execute(request);
            var responseJson = response.Content;
            string? token = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson)["access_token"].ToString();
            return token;
        }


        public async Task<Albums> GetAlbums()
        {
            var AlbumId = "4aawyAB9vmqN3uQ7FjRGTy";
   
            var options = new RestClientOptions($"{BaseUrl}albums/{AlbumId}")
            {
                Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(getToken(), "Bearer")
                    
            };
            RestClient client = new RestClient(options);
            RestRequest request = new RestRequest("", Method.Get);

           
            /**
            request.AddHeader("authorization", $"Bearer {getToken()}");
            **/
            request.AddHeader("cache-control", "no-cache");

            var response = await client.ExecuteGetAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var results = JsonConvert.DeserializeObject<Albums>(response.Content);


                return results;

            }

            throw new Exception("Unable to perform Request");
            
        }
    }
}
