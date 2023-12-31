﻿using Aspose.Email.Mime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    class CheckMessageForEncryption
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Email();
            string publicCertFile = dataDir + "MartinCertificate.cer";
            string privateCertFile = dataDir + "MartinCertificate.pfx";
                        
            // ExStart:CheckMessageForEncryption
            MailMessage mailMessageOrig = MailMessage.Load(Path.Combine(dataDir, "Message.msg"), new MsgLoadOptions());
            X509Certificate2 publicCert = new X509Certificate2(publicCertFile);
            X509Certificate2 privateCert = new X509Certificate2(privateCertFile, "anothertestaccount");

            Console.WriteLine("Message is encrypted: {0}" , mailMessageOrig.IsEncrypted);
            MailMessage mailMessage = mailMessageOrig.Encrypt(publicCert);
            Console.WriteLine("Message is encrypted: {0}", mailMessage.IsEncrypted);
            mailMessage = mailMessage.Decrypt(privateCert);
            Console.WriteLine("Message is encrypted: {0}", mailMessage.IsEncrypted);
            // ExEnd:CheckMessageForEncryption
        }

        public static X509Certificate2 GetTestCertificate(string dataDir)
        {
            string publicCertFile = dataDir + "MartinCertificate.cer";
            X509Certificate2 publicCert = new X509Certificate2(publicCertFile);
            return publicCert;
        }
    }
}
