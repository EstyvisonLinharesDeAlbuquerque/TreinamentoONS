using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.Pitang.ONS.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IList<User> listUsers();

    }
}
