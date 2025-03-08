using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class SimpleContextDb : DbContext
    {
        public SimpleContextDb(DbContextOptions<SimpleContextDb> options)
        : base(options)
        {
        }

        public DbSet<User> Userss { get; set; }
    }
}
