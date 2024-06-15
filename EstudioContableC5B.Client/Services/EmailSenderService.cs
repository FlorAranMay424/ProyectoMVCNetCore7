using EstudioContableC5B.Client.Models;

namespace EstudioContableC5B.Client.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly SmtpSettings _smtpSettings;

        public EmailSenderService(SmtpSettings smtpSettings)
        {
            _smtpSettings = smtpSettings;
        }

         public Task SendEmailAsync(MailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
