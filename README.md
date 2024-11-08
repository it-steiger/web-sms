# Very simple WebSMS Service
A library for sending web sms via linkmobility

## Getting Started

### Install the Package
```shell
dotnet add package ITSteiger.WebSmsClient --version 1.0.0
```

It's quiet simple to initalize a WebSms Client, you only need the Api Access Token
this token you can get in your link mobility account:
https://account.linkmobility.eu

Here is a simple example:
It's necessary to pass a HttpClient instance to the WebSmsService constructor.
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
## AspNetCore Support
For AspNetCore Projects there exist a separate package
### Install the Package
```shell
dotnet add package ITSteiger.WebSmsClient.AspNetCore --version 8.0.0
```
### Integration
Because the WebSmsService injects a HttpClient through Dependency Injection, it's necessary to register a HttpClient in this scope.
Best Practice is regist the HttClient by AddHttpClient()

Please insert this line before you register the WebSmsService
```csharp
builder.Services.AddHttpClient();
```
Here you can find, how you can register the WebSmsService, in the following example,
the access token was stored in the appsettings.json
```csharp
builder.Services.AddWebSmsClient(options => options
    .UseAccessToken(builder.Configuration.GetValue<string>("Access_Token")!));
```
For Example you can inject the IWebSmsService
```csharp
public class SendSmsCommandHandler(IWebSmsService smsService)()
{

}
```

