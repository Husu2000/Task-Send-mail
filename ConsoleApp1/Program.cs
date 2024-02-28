using System;
using System.Net;
using System.Net.Mail;

MailMessage mailMessage = new MailMessage();
mailMessage.From = new MailAddress("huseyn200825@gmail.com");
mailMessage.To.Add("talibliibrahim28@gmail.com");
mailMessage.Subject = "Salammm";
mailMessage.Body = "Necesen";

SmtpClient smtpClient = new SmtpClient();
smtpClient.Host = "smtp.gmail.com";
smtpClient.Port = 587;
smtpClient.UseDefaultCredentials = false;
smtpClient.Credentials = new NetworkCredential("huseyn200825@gmail.com", "imdq ayxq fneu nmbf");
smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
smtpClient.EnableSsl = true;
smtpClient.Send(mailMessage);