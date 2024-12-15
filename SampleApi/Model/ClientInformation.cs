namespace SampleApi.Controllers.Model
{
    public class ClientInformation
    {

        public string? ClientIp { get; set; }
        public int ClientPort { get; set; }
        public string? ClientName { get; set; }
        public string? ClientCertificate { get; set; }
        public int LocalServerPort { get; set; }

    }
}
