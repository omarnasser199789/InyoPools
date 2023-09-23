using InyoPools.Core.Domain.Model;
using InyoPools.Core.Domain.Model.Authentication;
using MimeKit;
using MailKit.Net.Smtp;


namespace InyoPoolsRest.API.Application.Aithentication
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }

    public class EmailService : IEmailService
    {

        private readonly EmailConfiguration _emailConfig;

        public EmailService(EmailConfiguration emailConfig) => _emailConfig = emailConfig;

        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }




        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("email", _emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };
            return emailMessage;
        }

        private void Send(MimeMessage emailMessage)
        {
            using var client = new SmtpClient();

            try
            {
                client.Connect(_emailConfig.SmtpServer, _emailConfig.port, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(_emailConfig.UserName, _emailConfig.Password);
                client.Send(emailMessage);

            }
            catch
            {
                throw;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }


        }
    }
}
