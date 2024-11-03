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
        protected MessageBase(List<string> recipients)
        {
            RecipientAddressList = recipients;
        }
        
        [JsonProperty("recipientAddressList")]
        public List<string> RecipientAddressList { get; set; }
    }
}