using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ELKLogging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpGet("InfoLog")]
        public string InfoLog()
        {
            _logger.LogInformation("info Log ");
            return string.Empty;
        }

        [HttpGet("WarningLog")]
        public string WarningLog()
        {
            _logger.LogWarning("warning Log ");
            return string.Empty;
        }

        [HttpGet("ErrorLog")]
        public string ErrorLog()
        {
            try
            {
                throw new Exception("YusufKORUCU");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return string.Empty;
        }
    }
}
