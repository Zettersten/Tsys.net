using System.Collections.Generic;
using Tsys.net.Models.GroupRecords;
using Tsys.net.Models.Messages;
using Tsys.net.Tests.Mocks;

namespace Tsys.net.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var authMessage = AuthorizationRequestMessageModel
                .NewAuthorizationMessageRequest("", MockIdentifierService.Group1Authorization_Retail, null, MockIdentifierService.StandardGroup3Records(null));

            System.Console.WriteLine(authMessage);

            System.Console.ReadKey();
        }
    }
}