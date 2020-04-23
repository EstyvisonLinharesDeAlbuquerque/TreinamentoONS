using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.Treinamento.ONS.Services
{
    public class ContactService
    {
        public static async Task<List<Contact>> GetAllUsers(
           DataContext context)
        {

            var contacts = await context.Contacts.AsNoTracking().ToListAsync();
            return contacts;
        }
    }
}
