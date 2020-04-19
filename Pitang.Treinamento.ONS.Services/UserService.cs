using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.Treinamento.ONS.Services
{
    public class UserService
    {
        public static async Task<List<User>> GetAllUsers(
           DataContext context)
        {

            var users = await context.Users.AsNoTracking().ToListAsync();
            return users;
        }
    }
}
