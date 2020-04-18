using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pitang.Treinamento.ONS.Data.Data
{
    class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

    }
}
