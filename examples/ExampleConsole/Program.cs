// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using WebSmsClient.Models;
using WebSmsClient.Services;

Console.WriteLine("Welcome to the Web SMS Example by IT-Steiger.NET");

var httpClient = new HttpClient();
var smsService = new WebSmsService(httpClient, new WebSmsServiceConfiguration
{
    ApiUrl = "https://api.linkmobility.eu",
    AccessToken = "YOUR TOKEN",
});

var response = await smsService
    .SendSmsAsync(new TextMessage("Hello World " + DateTime.Now, ["YOUR NUMBER"]), CancellationToken.None);

Console.WriteLine("Response: " + response);