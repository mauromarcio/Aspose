﻿using System;
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

namespace Aspose.Email.Examples.CSharp.Email.Knowledge.Base
{
    class SetAutofitForPrinting
    {
        public static void Run()
        {
            // ExStart:SetAutofitForPrinting
            string dataDir = RunExamples.GetDataDir_KnowledgeBase();

            // Instantiate an instance of MailPrinter
            Printing.MailPrinter printer = new Printing.MailPrinter();
            printer.FormattingFlags = Printing.MessageFormattingFlags.AutoFitWidth;
            MailMessage msg = MailMessage.Load(dataDir + "message3.msg", new MsgLoadOptions());
            printer.Print(msg, dataDir + "AutoFit_out.tiff", Printing.PrintFormat.Tiff);
            // ExEnd:SetAutofitForPrinting
        }
    }
}
