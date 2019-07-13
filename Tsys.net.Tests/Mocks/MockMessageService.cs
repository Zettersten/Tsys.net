using Tsys.net.Services.Messages;

namespace Tsys.net.Tests.Mocks
{
    public static class MockMessageService
    {
        public static MessageBuilderService MockMessageBuilderService()
        {
            return new MessageBuilderService(MockILoggerService.MockILogger<MessageBuilderService>());
        }
    }
}