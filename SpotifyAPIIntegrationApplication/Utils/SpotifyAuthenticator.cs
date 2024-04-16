using RestSharp;
using RestSharp.Authenticators;

namespace SpotifyAPIIntegrationApplication.Utils
{
    public class SpotifyAuthenticator : AuthenticatorBase
    {
        readonly string _baseUrl;
        readonly string _clientId;
        readonly string _clientSecret;

        public SpotifyAuthenticator(string baseUrl, string clientId, string clientSecret) : base("")
        {
            _baseUrl = baseUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            Token = string.IsNullOrEmpty(accessToken) ? await GetToken() : accessToken;

            return new HeaderParameter(KnownHeaders.Authorization, Token);
        }

        async Task<string?> GetToken()
        {
            var option = new RestClientOptions(_baseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(_clientId, _clientSecret)
            };
            using var client = new RestClient(option);

            var request = new RestRequest("oauth2/token")
                .AddParameter("grant_type", "client_credential");
            var response = await client.PostAsync(request);

            return response!.Content;
        }
    }
}
