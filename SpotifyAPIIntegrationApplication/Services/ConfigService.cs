using RestSharp;
using System.Net;
using System.Text.Json.Serialization;

namespace SpotifyAPIIntegrationApplication.Services
{
    public class ConfigService
    {
        private const string BaseUrl = "https://api.spotify.com/v1/";
        private const string URLParameter = "";
        private const string clientId = "caecbf56b7414889a048f2f1368b1f54";
        private const string clientSecret = "64ee50af24704c45a08d03fbe8ac2381";


        public string? webRequestResponse(string? requestPath)
        {
            var webClient = new RestClient(BaseUrl+"?");
            var request = new RestRequest($"/{requestPath}",Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");

            request.AddParameter("client_Id", clientId);
            request.AddParameter("client_secret", clientSecret);
            RestResponse response = webClient.Execute(request);

            return response.Content;
        }

        public RestResponse GetToken()
        {
            var webClient = new RestClient(BaseUrl);
            var request = new RestRequest("", Method.Post);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", 
                $"grant_type=client_credentials&scope=all&client_id={clientId}&client_secret={clientSecret}", 
                ParameterType.RequestBody);
            /**
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type""client_credentials");
            request.AddParameter("client_Id", clientId);
            request.AddParameter("client_secret", clientSecret);
            **/
            RestResponse response = webClient.Execute(request);

            return response;

            

        }

        public string? GetTokenString()
        {
            var request = GetToken();

            var response =  request?.Content;

            if (response?.Length == 0)
                throw new Exception("API authentication failed");

            return response;

        }
    }
}
