using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebSmsClient.Models;

namespace WebSmsClient.Services
{
    public class WebSmsService : IWebSmsService
    {
        private readonly WebSmsServiceConfiguration _config;
        private readonly HttpClient _httpClient;
        
        public WebSmsService(HttpClient httpClient, WebSmsServiceConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }
        
        public async Task<SendSmsResult> SendSmsAsync(TextMessage message, CancellationToken cancellationToken)
        {
            var url = $"{_config.ApiUrl}rest/smsmessaging/text";
            var httpMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(message.AsJson(), Encoding.UTF8, "application/json")
            };
            httpMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _config.AccessToken);
            
            var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
            var responseContent = await response.Content.ReadAsStringAsync();
            return new SendSmsResult
            {
                IsSuccessfully = response.IsSuccessStatusCode,
                StatusCode = response.StatusCode,
                ResponseText = responseContent
            };
        }
    }
}