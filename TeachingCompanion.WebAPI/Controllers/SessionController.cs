using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeachingCompanion.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;

        public SessionController(ILogger<SessionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Models.Session> GetAsync(Guid id)
        {
            await DoNothing(); //- Shushing warnings

            return new Models.Session()
            {
                Id = id
            };
        }

        [HttpPost]
        public async Task PostAsync([FromBody] Models.Session session)
        {
            await DoNothing(); //- Shushing warnings
        }

        private Task DoNothing()
        {
            return Task.CompletedTask;
        }
    }
}
