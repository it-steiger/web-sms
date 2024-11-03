using System.Collections.Generic;

namespace WebSmsClient.Models
{
    internal class WebSmsMessage
    {
        public string MessageContent { get; set; } = null!;
        public List<string> RecipientAddressList { get; set; } = null!;
    }
}