﻿using Aspose.Email.Mapi;
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

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class EmbedMessageAsAttachment
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Outlook();

            // ExStart:EmbedMessageAsAttachment
            MapiMessage message = new MapiMessage("from@test.com", "to@test.com", "Subj", "This is a message body");
            MapiMessage attachMsg = MapiMessage.FromFile(dataDir + "Message.msg");
            message.Attachments.Add("Weekly report.msg", attachMsg);
            message.Save(dataDir + "WithEmbeddedMsg_out.msg");
            // ExEnd:EmbedMessageAsAttachment
        }
    }
}
