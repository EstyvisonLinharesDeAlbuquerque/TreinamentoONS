using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Pitang.ONS.Services
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetAllContacts();
        Task<Contact> GetContact(int id);

        Contact Add(Contact contact);

        Task<Contact> AddAsync(Contact contact);

        Task<Contact> Update(Contact contact);

        void Delete(Contact contact);
    }
}

