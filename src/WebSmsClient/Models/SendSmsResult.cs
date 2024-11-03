using System.Net;

namespace WebSmsClient.Models
{
    public class SendSmsResult
    {
        public bool IsSuccessfully { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string? ResponseText { get; set; }

        public override string ToString()
        {
            return $"StatusCode: {StatusCode}, ResponseText: {ResponseText}";
        }
    }
}