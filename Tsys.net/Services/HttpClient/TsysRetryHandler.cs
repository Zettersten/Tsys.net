using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Tsys.net.Models.Config;

namespace Tsys.net.Services.HttpClient
{
    public class TsysRetryHandler : DelegatingHandler
    {
        // Strongly consider limiting the number of retries - "retry forever" is
        // probably not the most user friendly way you could respond to "the
        // network cable got pulled out."
        private readonly int MaxRetries;
        private readonly int MaxDelayInSecond;

        private readonly ILogger logger;

        public TsysRetryHandler(HttpMessageHandler innerHandler, TsysClientOptions tsysClientOptions, ILogger logger) : base(innerHandler)
        {
            MaxRetries = tsysClientOptions.MaxRetries;
            MaxDelayInSecond = tsysClientOptions.MaxDelayInSecond;

            this.logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;

            for (int i = 0; i < MaxRetries; i++)
            {
                response = await base.SendAsync(request, cancellationToken);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }

                logger.LogInformation($"Attempting to retry this request. This is the {i} attempt for the following url: '{request.RequestUri}'");

                await Task.Delay(TimeSpan.FromSeconds(MaxDelayInSecond), cancellationToken);
            }

            return response;
        }
    }
}