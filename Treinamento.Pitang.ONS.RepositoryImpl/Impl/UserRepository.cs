using Pitang.Treinamento.ONS.Data.Data;
using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Treinamento.Pitang.ONS.Repository;

namespace Treinamento.Pitang.ONS.RepositoryImpl
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext dbContext) : base(dbContext)
        { }
    }
}
