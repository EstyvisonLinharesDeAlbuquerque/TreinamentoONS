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
        public abstract Task<List<User>> GetAllUsers(DataContext context);
      
    }
}
