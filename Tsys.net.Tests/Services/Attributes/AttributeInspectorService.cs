using Tsys.net.Models;
using Tsys.net.Tests.Mocks;
using Xunit;

namespace Tsys.net.Tests.Services.Attributes
{
    [Collection("0.0.0")]
    public class AttributeInspectorService
    {
        [Fact(DisplayName = "0.0.0 - Should get object and it's attributes")]
        public void Should_get_attributes_and_its_object()
        {
            var message = MockIdentifierService.MockTsysMessageModel();
            var a = new Tsys.net.Services.Attributes.AttributeInspectorService<TsysAuthenticationMessageModel>(message);

            var b = a.BuildMessage();
        }
    }
}