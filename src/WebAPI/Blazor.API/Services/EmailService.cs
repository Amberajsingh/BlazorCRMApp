using System.Net;
using System.Net.Mail;
using System.Reflection;

namespace Blazor.API.Services
{
    public class EmailService
    {
        public EmailService()
        {
        }

        public async Task SendEmailAsync(string ToEmails, string subject, string message)
        {
            if (string.IsNullOrWhiteSpace(ToEmails))
            {
                throw new ArgumentNullException("ToEmails");
            }

            if (string.IsNullOrWhiteSpace(subject))
            {
                throw new ArgumentNullException("subject");
            }

            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentNullException("message");
            }

            try
            {
                using (var client = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "wds12@24livehost.com",
                        Password = "1SD6cRugr124"
                    };

                    client.Credentials = credential;

                    client.Host = "mail.24livehost.com";
                    client.Port = 587;
                    client.EnableSsl = true;

                    using (var emailMessage = new MailMessage())
                    {
                        emailMessage.IsBodyHtml = true;

                        emailMessage.From = new MailAddress("wds12@24livehost.com", "Demo email");
                        

                        //---Set recipients in To List 
                        var _ToList = ToEmails.Replace(";", ",");
                        if (_ToList != "")
                        {
                            string[] arr = _ToList.Split(',');
                            emailMessage.To.Clear();
                            if (arr.Length > 0)
                            {
                                foreach (string address in arr)
                                {
                                    if (address != "")
                                    {
                                        emailMessage.To.Add(new MailAddress(address));
                                    }
                                }
                            }
                            else
                            {
                                emailMessage.To.Add(new MailAddress(_ToList));
                            }
                        }

                        emailMessage.Subject = subject;
                        emailMessage.Body = message;
                        client.Timeout = 2000000;
                        await client.SendMailAsync(emailMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            await Task.CompletedTask;
        }
    }
}

