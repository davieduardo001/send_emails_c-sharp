using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace send_emails_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string email_title;
            string email_message;
            string email_sender_password;

            Console.WriteLine("What is the email title? ");
            email_title = Console.ReadLine();

            Console.WriteLine("What is the message? ");
            email_message = Console.ReadLine();

            Console.WriteLine("What is the password of the sender: ");
            email_sender_password = Console.ReadLine();

            Console.WriteLine("Press ENTER to send the email!");
            Console.ReadLine();

            try
            { 
                MailMessage message = new MailMessage("", ""); // sender email addressee email

                message.Subject = "";
                message.IsBodyHtml = true;
                message.Body = "<p>" + email_message + "</p>";
                message.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                message.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtp_client = new SmtpClient("smtp.gmail.com", 587);

                smtp_client.UseDefaultCredentials = false;
                smtp_client.Credentials = new NetworkCredential("", ""); // Email and passoword of the sender

                smtp_client.EnableSsl = true;

                smtp_client.Send(message);

                Console.WriteLine("The email was sent successfully! :] ");
                Console.ReadLine();
            }catch
            {
                Console.WriteLine("An error has occurred :[ ");
                Console.ReadLine();
            }
        }
    }
}
