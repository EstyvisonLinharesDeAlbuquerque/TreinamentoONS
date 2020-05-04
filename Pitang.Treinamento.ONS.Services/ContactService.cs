using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Treinamento.Pitang.ONS.Repository;
using Treinamento.Pitang.ONS.Services;

namespace Pitang.Treinamento.ONS.Services
{
    public class ContactService : IContactService
    {
        private IContactRepository _repository;
        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Contact>> GetAllContacts()
        {
            IEnumerable<Contact> contacts;
            contacts = await _repository.FindAllAsync();
            return contacts;
        }

        public async Task<Contact> GetContact(int id)
        {
            var contact = await _repository.FindBy(x => x.Id == id);
            return contact.FirstOrDefault();

        }

        public Contact Add(Contact contact)
        {
            return _repository.Add(contact);
        }

        public async Task<Contact> AddAsync(Contact contact)
        {
            return await _repository.AddAsync(contact);
        }

        public async Task<Contact> Update(Contact contact)
        {
            var contactUpdated = await _repository.Update(contact);
            return contactUpdated.FirstOrDefault();
        }

        public void Delete(Contact contact)
        {

            _repository.Delete(contact);

        }
    }
}

