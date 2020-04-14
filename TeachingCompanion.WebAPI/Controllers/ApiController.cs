using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCompanion.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        public IActionResult Index()
        {
            return new ContentResult()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Content = "The api works.",
                ContentType = "text/plain"
            };
        }
    }
}