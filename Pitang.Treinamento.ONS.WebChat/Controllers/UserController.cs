using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Services;

namespace Pitang.Treinamento.ONS.WebChat.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<User>>> Get([FromServices] DataContext contexto)
        {

            var users = await UserService.GetAllUsers(contexto);
            return Ok(users);
        }
    }
}