using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.entity
{
    public class Context : DbContext
    {
        public DbSet<dbUser> dbUsers { get; set; }

        public DbSet<dbCategory> dbCategories { get; set; }

        public DbSet<dbContent> dbContents { get; set; }
    }
}
