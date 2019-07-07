using Microsoft.VisualStudio.TestTools.WebTesting;
using System.ComponentModel;
using System.Configuration;
using System.Net.Http;

namespace TestPlugins
{
    [DisplayName("Add Authorization Header")]
    [Description("Add Authorization header to Web Request")]
    public class AuthorizationHeaderTokenPlugin : WebTestRequestPlugin
    {

        
        [DisplayName("UserName")]
        [Description("UserName")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        [Description("Password")]
        public string Password { get; set; }

        public override void PreRequest(object sender, PreRequestEventArgs e)
        {
            if (string.IsNullOrEmpty(UserName))
                UserName = "Paulcollins1";
            if (string.IsNullOrEmpty(Password))
                Password = "warwick";
            

            HttpClient client = new HttpClient();
            string token = GetToken(client, UserName, Password);

            e.Request.Headers.Add("Authorization", "Bearer " + token);
            e.Request.Headers.Add("Accept", "application/json");
        }

        private string GetToken(HttpClient client, string userName, string password)
        {
            //return GetStsAccessToken(stsEndpoint, userName, password).Result;
            return "";
        }

        //private async Task<string> GetStsAccessToken(string baseAddress, string clientId, string secret, string scope)
        //{
        //    var tokenClient = new TokenClient($"{baseAddress}connect/token", clientId, secret, style: AuthenticationStyle.PostValues);

        //    var tokenClientResult = await tokenClient.RequestClientCredentialsAsync(scope);

        //    if (tokenClientResult.IsError) throw new Exception(tokenClientResult.Error);

        //    return tokenClientResult.AccessToken;
        //}
    }
}
