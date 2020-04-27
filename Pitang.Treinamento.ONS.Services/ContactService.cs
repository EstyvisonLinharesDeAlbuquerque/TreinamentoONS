using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pitang.Treinamento.ONS.Services
{
    public class ContactService
    {
        public static async Task<List<Contact>> GetAllContacts(
           DataContext context)
        {

            var contacts = await context.Contacts.AsNoTracking().ToListAsync();
            return contacts;
        }
    }
}
