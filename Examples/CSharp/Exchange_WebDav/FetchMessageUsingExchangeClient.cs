﻿using Aspose.Email.Clients.Exchange;
using Aspose.Email.Clients.Exchange.Dav;
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

namespace Aspose.Email.Examples.CSharp.Email.Exchange_WebDav
{
    class FetchMessageUsingExchangeClient
    {
        public static void Run()
        {
            try
            {
                // ExStart:FetchMessageUsingExchangeClient
                // Create instance of ExchangeClient class by giving credentials
                ExchangeClient client = new ExchangeClient("http://ex07sp1/exchange/Administrator", "user", "pwd", "domain");

                // Call ListMessages method to list messages info from Inbox
                ExchangeMessageInfoCollection msgCollection = client.ListMessages(client.GetMailboxInfo().InboxUri);

                // Loop through the collection to get Message URI
                foreach (ExchangeMessageInfo msgInfo in msgCollection)
                {
                    string strMessageURI = msgInfo.UniqueUri;

                    // Now get the message details using FetchMessage()
                    MailMessage msg = client.FetchMessage(strMessageURI);
                    foreach (Attachment att in msg.Attachments)
                    {
                        Console.WriteLine("Attachment Name: " + att.Name);
                    }
                }
                // ExEnd:FetchMessageUsingExchangeClient
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
