namespace WebSmsClient.Models
{
    public class WebSmsServiceConfiguration
    {
        private string _apiUrl = "https://api.linkmobility.eu/";

        public string ApiUrl
        {
            get => _apiUrl;
            set
            {
                var url = value;
                if (!url.EndsWith("/"))
                    url += "/";
                
                _apiUrl = url;
            }
        }

        public string AccessToken { get; set; } = null!;
        
        public void UseAccessToken(string accessToken) => AccessToken = accessToken;
    }
}