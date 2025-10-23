using CharlieBackend.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}