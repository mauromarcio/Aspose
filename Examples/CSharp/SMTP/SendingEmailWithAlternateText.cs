﻿using Aspose.Email.Clients.Smtp;
using Aspose.Email.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/email
*/

namespace Aspose.Email.Examples.CSharp.Email.SMTP
{
    class SendingEmailWithAlternateText
    {
        public static void Run()
        {
            // ExStart:SendingEmailWithAlternateText
            // Create an instance of MailMessage class
            MailMessage message = new MailMessage();

            // From and To field
            message.From = "sender@sender.com";
            message.To.Add("receiver@receiver.com");

            AlternateView alternate;

            // Create an instance of AlternateView to view an email message using the content specified in the string
            alternate = AlternateView.CreateAlternateViewFromString("This is the alternate Text");

            // Add alternate text
            message.AlternateViews.Add(alternate);

            // Create an instance of SmtpClient Class
            SmtpClient client = new SmtpClient();

            // Specify your mailing host server, user name, mail password and Port #
            client.Host = "smtp.server.com";
            client.Username = "Username";
            client.Password = "Password";
            client.Port = 25;
            try
            {
                // Client.Send will send this message
                client.Send(message);
            }

            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
            // ExEnd:SendingEmailWithAlternateText

        }
    }
}
