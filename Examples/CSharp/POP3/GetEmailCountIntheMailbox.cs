﻿using Aspose.Email.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Email.Examples.CSharp.Email.POP3
{
    class GetEmailCountIntheMailbox
    {
        public static void Run()
        {
            // ExStart:GetEmailCountIntheMailbox
            Pop3Client client = new Pop3Client("pop3.server.com", "username", "password");
            try
            {
                client.SecurityOptions = SecurityOptions.Auto;
                int i = client.GetMessageCount();
                Console.WriteLine("Message count: " + i);
            }
            catch (Pop3Exception ex)
            {
                Console.WriteLine("Error:" + ex.ToString());
            }
            // ExEnd:GetEmailCountIntheMailbox
        }
    }
}
