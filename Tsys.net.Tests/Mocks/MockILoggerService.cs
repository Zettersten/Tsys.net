using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Tsys.net.Tests.Mocks
{
    public static class MockILoggerService
    {
        public static ILogger<T> MockILogger<T>()
        {
            return new NullLogger<T>();
        }
    }
}