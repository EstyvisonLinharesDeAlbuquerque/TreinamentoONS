using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Services;
using Treinamento.Pitang.ONS.Services;
using Treinamento.Pitang.ONS.Views;

namespace Treinamento.Pitang.ONS.WebChat.Controllers
{
    [Route("contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IEnumerable<Contact> _contacts;
        private IContactService _contactService;
        public ContactController(IMapper mapper, IContactService contactService)
        {
            _mapper = mapper;
            _contactService = contactService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<ContactDto>>> Get()
        {
            _contacts = await _contactService.GetAllContacts();
            List<ContactDto> contactsDto = new List<ContactDto>();
            foreach (Contact contact in _contacts)
            {
                contactsDto.Add(_mapper.Map<Contact, ContactDto>(contact));
            }
            return contactsDto;
        }

        
        [HttpGet]
        [Route("{id:int}")]
        //[Authorize(Roles = "usuario")]
        public async Task<ActionResult<ContactDto>> GetById(
            int id,
            [FromServices] DataContext context)
        {

            var contact = await _contactService.GetContact(id);

            ContactDto contactDto = _mapper.Map<Contact, ContactDto>(contact);

            if (contactDto == null)
                return NotFound(new { message = "Contato não encontrado" });

            return contactDto;
        }
        
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<ContactDto>> Post([FromBody]ContactDto modelDto,
            [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            Contact contact = _mapper.Map<ContactDto, Contact>(modelDto);

            _contactService.Add(contact);
            await context.SaveChangesAsync();
            var newContactDto = _mapper.Map<Contact, ContactDto>(await _contactService.GetContact(contact.Id));
            return newContactDto;
        }

      
        [HttpPut]
        [Route("{id:int}")]
        //[Authorize(Roles = "usuario")]
        public async Task<ActionResult<ContactDto>> Put(int id, [FromBody] ContactDto modelDto)
        {

            Contact contact = _mapper.Map<ContactDto, Contact>(modelDto);
            if (id != contact.Id)
            {
                return NotFound(new { message = "Contato não encontrado!" });
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newContactDto = _mapper.Map<Contact, ContactDto>(await _contactService.Update(contact));

            return newContactDto;
        }
        
       [HttpDelete]
       [Route("{id:int}")]
       //[Authorize(Roles = "admin")]
       public async Task<ActionResult<Contact>> Delete(int id)
       {

           var contact = await _contactService.GetContact(id);
           if (contact == null)
               return NotFound(new { message = "Usuário não encontrado" });
           contact.IsDeleted = true;

           _contactService.Delete(contact);

           return Ok();

       }
    }
}