using Microsoft.AspNetCore.Mvc;
using WebSmsClient.Models;
using WebSmsClient.Services;

namespace ExampleAspNetCore.Controllers;

[ApiController]
[Route("api/v1/web-sms")]
public class WebSmsController(IWebSmsService smsService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SendSms([FromBody] TextMessage message, CancellationToken cancellationToken)
    {
        var response = await smsService.SendSmsAsync(message, cancellationToken);
        return response.IsSuccessfully ? Ok() : BadRequest(response.ResponseText);
    }
}