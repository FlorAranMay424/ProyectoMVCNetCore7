using EstudioContableC5B.Client.Models;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace EstudioContableC5B.Client.Services
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(MailRequest request);
    }
}
