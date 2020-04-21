using MasterData.Services.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterData.Services.Context
{
    public class MPTContext : DbContext
    {
        public MPTContext(DbContextOptions<MPTContext> options)
            : base(options)
        { 
        }

        public DbSet<CustomerPool> CustomerPools { get; set; }

    }
}
