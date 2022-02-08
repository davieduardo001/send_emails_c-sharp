using System;
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

            Console.WriteLine("What is the email title? ");
            email_title = Console.ReadLine();

            Console.WriteLine("What is the message? ");
            email_message = Console.ReadLine();

            MailMessage message = new MailMessage("", "");

            message.Subject = "";
            message.IsBodyHtml = true;
            message.Body = "<p>" + email_message + "</p>";
            message.SubjectEncoding = Encoding.GetEncoding("UTF-8");
            message.BodyEncoding = Encoding.GetEncoding("UTF-8");
        }
    }
}
