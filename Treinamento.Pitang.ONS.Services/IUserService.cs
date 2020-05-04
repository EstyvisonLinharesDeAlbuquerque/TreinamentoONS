using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Pitang.ONS.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(int id);

        User Add(User user);

        Task<User> AddAsync(User user);

        Task<User> Update(User user);

        void Delete(User user);
    }
}
