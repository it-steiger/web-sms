using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebSmsClient.Models
{
    public abstract class MessageBase
    {
        protected MessageBase()
        {
            RecipientAddressList = new List<string>();
        }
        protected MessageBase(IEnumerable<string> recipients)
        {
            RecipientAddressList = recipients;
        }
        
        [JsonProperty("recipientAddressList")]
        public IEnumerable<string> RecipientAddressList { get; set; }
    }
}