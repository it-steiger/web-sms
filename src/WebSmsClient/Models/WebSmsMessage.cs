using System.Collections.Generic;

namespace WebSmsClient.Models
{
    internal class WebSmsMessage
    {
        public string MessageContent { get; set; } = null!;
        public IEnumerable<string> RecipientAddressList { get; set; } = null!;
    }
}