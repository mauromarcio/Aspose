﻿using Aspose.Email.Mime;
using Aspose.Email.Mapi;
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

namespace Aspose.Email.Examples.CSharp.Email
{
    class CreateTNEFEMLFromMSG
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Email();

            // ExStart:CreateTNEFEMLFromMSG
            MapiMessage mapiMsg = MapiMessage.FromFile(dataDir + "Message.msg");

            MailConversionOptions mco = new MailConversionOptions();

            mco.ConvertAsTnef = true;

            MailMessage message = mapiMsg.ToMailMessage(mco); 
            // ExEnd:CreateTNEFEMLFromMSG
        }
    }
}
