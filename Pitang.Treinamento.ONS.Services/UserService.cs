using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using System.Collections.Generic;
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

        public static async Task<User> GetUser(
           DataContext context,
           int id)
        {
            var user = await context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

    }
}
