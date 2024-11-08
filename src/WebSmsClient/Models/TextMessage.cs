using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WebSmsClient.Models
{
    public class TextMessage : MessageBase
    {
        public TextMessage()
        {
            Content = string.Empty;
        }
        public TextMessage(string content, IEnumerable<string> recipients) : base(recipients)
        {
            Content = content;
        }
        public string Content { get; set; }

        public string AsJson()
        {
            var webSms = new WebSmsMessage
            {
                MessageContent = Content,
                RecipientAddressList = RecipientAddressList
            };
            
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };
            
            return JsonConvert.SerializeObject(webSms, settings);
        }
    }
}