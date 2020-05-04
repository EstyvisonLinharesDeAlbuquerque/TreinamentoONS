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
     public class UserService : IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            IEnumerable<User> users;
            users = await _repository.FindAllAsync();
            return users;
        }

        public async Task<User> GetUser(int id)
        {
           
           var user = await _repository.FindBy(x => x.Id == id);
           return user.FirstOrDefault();
        }
        
        public User Add(User user)
        {
            return _repository.Add(user);
        }

        public async Task<User> AddAsync(User user)
        {
            return await _repository.AddAsync(user);
        }

        public async Task<User> Update(User user)
        {
            var userUpdated = await _repository.Update(user);
            return userUpdated.FirstOrDefault();
        }

        public void Delete(User user)
        {
            
         _repository.Delete(user);
            
        }
           
     }
}

//x => x.Id == id