using Tsys.net.Models.Authorizations;
using Tsys.net.Extensions;

namespace Tsys.net.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var group1Auth = Group1AuthorizationModel
                .NewG1AuthorizationMessageRequest();

            System.Console.ReadKey();
        }
    }
}