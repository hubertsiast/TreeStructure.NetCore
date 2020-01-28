using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TreeStructure.WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NodesControler : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NodesControler> _logger;

        public NodesControler(ILogger<NodesControler> logger)
        {
            _logger = logger;
        }
    }
}
