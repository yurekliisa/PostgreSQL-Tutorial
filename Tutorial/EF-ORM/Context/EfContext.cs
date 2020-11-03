using EF_ORM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_ORM.Context
{
    public class EfContext:DbContext
    {
        public DbSet<Category>  Categories{ get; set; }

        public EfContext(DbContextOptions<EfContext> options):base(options)
        {
        }
    }

    
}
