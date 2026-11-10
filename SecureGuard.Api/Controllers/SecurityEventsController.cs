using Microsoft.AspNetCore.Mvc;
using SecureGuard.Api.Models;

namespace SecureGuard.Api.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class SecurityEventsController : ControllerBase
    {
        [HttpGet("example")]
        public ActionResult<SecurityEvent> GetExample()
        {
            var securityEvent = new SecurityEvent()
            {
                Host = "example-host",
                Source = "ssh",
                RawMessage = "Failed password for student from 192.168.1.20 port 50231 ssh2"
            };
            return Ok(securityEvent);
        }

        [HttpPost]
        public ActionResult<SecurityEvent> CreateSecurityEvent([FromBody] CreateSecurityEventRequest request)
        {
            var securityEvent = new SecurityEvent()
            {
                Host = request.Host,
                Source = request.Source,
                RawMessage = request.RawMessage
            };
            return Ok(securityEvent);
        }
    }
}
