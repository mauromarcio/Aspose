﻿using System;
using Aspose.Email.Mime;
using Aspose.Email.Clients.Exchange.WebService;
using Aspose.Email.Clients.Exchange;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/email
*/

namespace Aspose.Email.Examples.CSharp.Email.Exchange_EWS
{
    class AddMembersWithoutListing
    {
        public static void Run()
        {
            // ExStart:AddMembersWithoutListing
            IEWSClient client = EWSClient.GetEWSClient("https://outlook.office365.com/ews/exchange.asmx", "testUser", "pwd", "domain");
            ExchangeDistributionList distributionList = new ExchangeDistributionList();
            distributionList.Id = "list's id";
            distributionList.ChangeKey = "list's change key";
            MailAddressCollection newMembers = new MailAddressCollection();
            newMembers.Add("address6@host.com");
            client.AddToDistributionList(distributionList, newMembers);
            // ExEnd:AddMembersWithoutListing
        }
    }
}