using Microsoft.AspNetCore.Mvc;
using SampleApi.Controllers.Extensions;
using SampleApi.Controllers.Model;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("diagnostic")]
    public class DiagnosticInformationController : ControllerBase
    {

        public DiagnosticInformationController(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ping")]
        public IActionResult Ping()
        {
            string result = "PONG";

            return Ok(result);
        }

        [HttpGet("client-infos")]
        public IActionResult GetClientInfos()
        {
            string? clientIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
            int clientPortNumber = HttpContext.Connection.RemotePort;
            int localServerPort = HttpContext.Connection.LocalPort;

            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                clientIpAddress = Request.Headers["X-Forwarded-For"];
            }

            var clientInformation = new ClientInformation()
            {
                ClientIp = clientIpAddress ?? "The header value of X-Forwarded-For was not set.",
                ClientPort = clientPortNumber,
                LocalServerPort = localServerPort,
            };

            string clientInfoAsYaml = clientInformation
                .SerializeToYaml();

            return Ok(clientInfoAsYaml);
        }

        [HttpGet("server-configuration")]
        public IActionResult GetServerConfiguration()
        {
            var result = _configuration
                .AsEnumerable(true)
                .ToList()
                .SerializeToYaml();

            return Ok(result);
        }


        private readonly IConfiguration _configuration;


    }
}
