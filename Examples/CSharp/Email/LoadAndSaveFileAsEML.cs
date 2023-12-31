﻿using System.IO;
using Aspose.Email.Mime;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/email
*/

namespace Aspose.Email.Examples.CSharp.Email
{
    class LoadAndSaveFileAsEML
    {
        public static void Run()
        {
            // ExStart:LoadAndSaveFileAsEML
            // The path to the File directory.
            string dataDir = RunExamples.GetDataDir_Email();

            // Initialize and Load an existing EML file by specifying the MessageFormat
            MailMessage mailMessage = MailMessage.Load(dataDir + "Attachments.eml");

            mailMessage.Save(dataDir + "LoadAndSaveFileAsEML_out.eml", SaveOptions.DefaultEml);
            // ExEnd:LoadAndSaveFileAsEML
        }
    }
}
