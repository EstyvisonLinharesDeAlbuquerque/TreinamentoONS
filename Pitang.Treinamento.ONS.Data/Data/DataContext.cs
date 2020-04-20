using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pitang.Treinamento.ONS.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Messages> Messages { get; set; }

        public DbSet<Contact> Strory { get; set; }


    }
}
