using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Services;

namespace Treinamento.Pitang.ONS.WebChat.Controllers
{
    [Route("contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Contact>>> Get(
            [FromServices] DataContext context)
        {
            try
            {
                var contacts = await ContactService.GetAllUsers(context);
                return Ok(contacts);

            }
            catch
            {
                return BadRequest(new { message = "Não foi possível buscar os contatos" });
            }

        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Contact>> Post(
            [FromBody] Contact model,
            [FromServices] DataContext context
            )
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                context.Contacts.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);

            }
            catch
            {
                return BadRequest(new { message = "Não foi possível criar o contato" });

            }
        }

        [HttpPut]
        [Route("{id:int}")]
        //[Authorize(Roles = "usuario")]
        public async Task<ActionResult<Contact>> Put(
           int id,
           [FromBody] Contact model,
           [FromServices] DataContext context)
        {

            if (id != model.Id)
            {
                return NotFound(new { message = "Contato não encontrado!" });
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                context.Entry(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);

            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest(new { message = "Uma alteração já está sendo realizada" });
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível alterar o usuário." });
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<Contact>> Delete(
            int id,
            [FromServices] DataContext context
            )
        {
            var contact = await context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            if (contact == null)
                return NotFound(new { message = "Usuário não encontrado" });

            try
            {
                context.Contacts.Remove(contact);
                await context.SaveChangesAsync();

                return Ok(new { message = "Contato deletado com sucesso!" });
            }
            catch
            {

                return BadRequest(new { message = "Não foi possível excluir o usuário." });
            }

        }
    }
}