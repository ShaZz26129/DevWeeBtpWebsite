using System.Net.Mail;
using System.Net;

namespace WeeBtpWebsite.Services
{
    public class BrevoMailService
    {

        public void SendEmail(string name, string email, string subject, string phoneNumber, string message)
        {
            //string recipient = Request.Form["recipient"];
            //string subject = Request.Form["subject"];
            //string messageBody = Request.Form["message"];
            try
            {
                //sib_api_v3_sdk.Client.Configuration.Default.ApiKey.Add("api-key", "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");
                //var apiInstance = new TransactionalEmailsApi();
                //string SenderName = "We(e)btp";
                //string SenderEmail = "sales@weebtp.com";
                //SendSmtpEmailSender Email = new SendSmtpEmailSender(SenderName, SenderEmail);
                //string ToEmail = "sales@weebtp.com ";
                //string ToName = "We(e) Your Technology Partners";
                //SendSmtpEmailTo smtpEmailTo = new SendSmtpEmailTo(ToEmail, ToName);
                //List<SendSmtpEmailTo> To = new List<SendSmtpEmailTo>();
                //To.Add(smtpEmailTo); 
                //string HtmlContent = "<html><body><h1>This is a Test Email</h1></body></html>";
                //string Subject = subject;
                //string TextContent = $"<p>{email},</p><br/>" + $"<p>{phoneNumber},</p><br/>"+$"<p>{message}</p>";
                ////string ReplyToName = "";
                ////string ReplyToEmail = "";
                ////SendSmtpEmailReplyTo ReplyTo = new SendSmtpEmailReplyTo(ReplyToEmail, ReplyToName);
                //var sendSmtpEmail = new SendSmtpEmail(Email,null,null,null,HtmlContent,TextContent,Subject);
                //CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress("no-reply@weebtp.com"); // Your email address
                    mailMessage.To.Add("sales@weebtp.com");
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Subject = subject;
                    mailMessage.Body = $"<h2>Hello Weebtp Sales Team</h2>" + $"<p>Name: {name}.</p>" +
                        $"<p>Contact no.: {phoneNumber}</p>" +
                        $"<p>Email: {email}.</p>" +
                        $"<p>Message :{message}.</p>";

                    using (SmtpClient smtpClient = new SmtpClient("weebtp.com"))
                    {
                        // Use the appropriate port for your SMTP server
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new NetworkCredential("no-reply@weebtp.com", "6w9d8Zt@7"); // Your credentials
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mailMessage);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
