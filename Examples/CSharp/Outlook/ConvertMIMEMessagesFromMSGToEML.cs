﻿using Aspose.Email.Mime;
using Aspose.Email.Mapi;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/email
*/

namespace Aspose.Email.Examples.CSharp.Email.Outlook
{
    class ConvertMIMEMessagesFromMSGToEML
    {
        public static void Run()
        {
            // ExStart:ConvertMIMEMessagesFromMSGToEML
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Outlook();
            MailMessage msg = MailMessage.Load(dataDir + "message.eml");
            MapiMessage mapi = MapiMessage.FromMailMessage(msg, new MapiConversionOptions(OutlookMessageFormat.Unicode));
            // Save File to disk
            mapi.Save(dataDir + "ConvertMIMEMessagesFromMSGToEML_out.msg");
            // ExEnd:ConvertMIMEMessagesFromMSGToEML
        }
    }
}