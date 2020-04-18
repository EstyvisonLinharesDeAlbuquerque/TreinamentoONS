using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pitang.Treinamento.ONS.WebChat.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult<string> Get()
        {
            var value = "Olá mundo";
            return Ok(value);
        }
    }
}