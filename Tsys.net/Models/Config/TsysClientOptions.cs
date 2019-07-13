namespace Tsys.net.Models.Config
{
    public class TsysClientOptions
    {
        public const string TSYS_TEST_URL_1 = "https://ssltest.tsysacquiring.net/";
        public const string TSYS_TEST_URL_2 = "https://ssltest2h.tsysacquiring.net/";
        public const string TSUS_PROD_URL_1 = "https://ssl1.tsysacquiring.net/";
        public const string TSUS_PROD_URL_2 = "https://ssl1.vitalps.net/";

        public string BaseUrl { get; set; } = TSYS_TEST_URL_1;

        public int MaxDelayInSecond { get; set; } = 3;

        public int MaxRetries { get; set; } = 3;
    }
}