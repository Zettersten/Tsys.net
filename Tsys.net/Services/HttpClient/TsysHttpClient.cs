﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using Tsys.net.Models.Config;

namespace Tsys.net.Services.HttpClient
{
    public class TsysHttpClient : System.Net.Http.HttpClient
    {
        private readonly IOptions<TsysClientOptions> tsysClientOptions;
        private readonly ILogger logger;

        public TsysHttpClient(IOptions<TsysClientOptions> tsysClientOptions, ILogger<TsysHttpClient> logger) : base(new TsysRetryHandler(new HttpClientHandler(), tsysClientOptions.Value, logger))
        {
            this.logger = logger;
            BaseAddress = new Uri(tsysClientOptions.Value.BaseUrl);
        }
    }
}