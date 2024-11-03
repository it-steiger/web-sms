#### A library for sending web sms via linkmobility
# Get Started

```csharp
var httpClient = new HttpClient();
var smsService = new WebSmsService(httpClient, new WebSmsServiceConfiguration
{
ApiUrl = "https://api.linkmobility.eu",
AccessToken = "YOUR TOKEN",
});

var response = await smsService
.SendSmsAsync(new TextMessage("Hello World " + DateTime.Now, ["YOUR NUMBER"]), CancellationToken.None);
```