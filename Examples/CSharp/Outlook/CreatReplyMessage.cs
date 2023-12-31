﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Email.Storage.Pst;
using Aspose.Email;
using Aspose.Email.Mapi;
using Aspose.Email.Tools;

/* This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET 
   API reference when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq 
   for more information. If you do not wish to use NuGet, you can manually download 
   Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
   install it and then add its reference to this project. For any issues, questions or suggestions 
   please feel free to contact us using https://forum.aspose.com/c/email            
*/

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class CreatReplyMessage
    {
        public static void Run()
        {
            // ExStart:CreatReplyMessage
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Outlook();

            MapiMessage originalMsg = MapiMessage.FromFile(dataDir + "message1.msg");
            ReplyMessageBuilder builder = new ReplyMessageBuilder();

            // Set ReplyMessageBuilder Properties
            builder.ReplyAll = true;
            builder.AdditionMode = OriginalMessageAdditionMode.Textpart;
            builder.ResponseText = "<p><b>Dear Friend,</b></p> I want to do is introduce my co-author and co-teacher. <p><a href=\"www.google.com\">This is a first link</a></p><p><a href=\"www.google.com\">This is a second link</a></p>";
            
            MapiMessage replyMsg = builder.BuildResponse(originalMsg);
            replyMsg.Save(dataDir+ "reply_out.msg");
            // ExEnd:CreatReplyMessage
        }

    }
}
