using System;
using Tsys.net.Models;
using Tsys.net.Tests.Mocks;

namespace Tsys.net.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var message = MockIdentifierService.MockTsysMessageModel();
            var a = new Services.Attributes.AttributeInspectorService<TsysAuthenticationMessageModel>(message);

            System.Console.WriteLine(a.BuildMessage());
            System.Console.ReadKey();
        }
    }
}