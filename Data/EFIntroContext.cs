using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameWorkIntro.Models;

namespace EntityFrameWorkIntro.Data
{
    public class EFIntroContext : DbContext
    {
        public EFIntroContext (DbContextOptions<EFIntroContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameWorkIntro.Models.Clients> Clients { get; set; }

        public DbSet<EntityFrameWorkIntro.Models.Orders> Orders { get; set; }

        public DbSet<EntityFrameWorkIntro.Models.Products> Products { get; set; }
    }
}
