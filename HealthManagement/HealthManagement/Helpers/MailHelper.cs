using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace HealthManagement.Helpers
{
    public class MailHelper
    {
        private IConfiguration configuration;

        public MailHelper(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public bool Send(string from, string to, string subject, string content)
        {
            try
            {
                var host = configuration["Gmail:Host"].ToString();
                var port = int.Parse(configuration["Gmail:Port"].ToString());
                var username = configuration["Gmail:Username"].ToString();
                var password = configuration["Gmail:Password"].ToString();
                var enable = bool.Parse(configuration["Gmail:SMTP:StartTLS:Enable"].ToString());
                var smtpClient = new SmtpClient
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enable,
                    Credentials = new NetworkCredential(username, password)
                };
                var mailMessage = new MailMessage(from, to, subject, content);
                mailMessage.IsBodyHtml = true;
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}
