using System.Threading;
using System.Threading.Tasks;
using WebSmsClient.Models;

namespace WebSmsClient.Services
{
    public interface IWebSmsService
    {
        Task<SendSmsResult> SendSmsAsync(TextMessage message, CancellationToken cancellationToken);
    }
}