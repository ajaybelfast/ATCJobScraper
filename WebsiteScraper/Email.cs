﻿using System;
using System.Net;
using System.Net.Mail;

namespace WebsiteScraper
{
    class Email
    {
        public static void sendEmail(string subject, string body)
        {
            MailMessage email = new MailMessage();
            email.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            email.To.Add("ajaybelfast@hotmail.com");
            email.From = new MailAddress("ajaybelfastsydney@gmail.com");

            email.Subject = subject;
            email.Body = body;

            SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
            server.EnableSsl = true;
            server.DeliveryMethod = SmtpDeliveryMethod.Network;
            server.UseDefaultCredentials = false;
            server.Credentials = new NetworkCredential("ajaybelfastsydney@gmail.com", "93deskwood");

            server.Send(email);
            Console.WriteLine("Email has been sent successfully");
        }
    }
}