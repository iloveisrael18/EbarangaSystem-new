using EBarangaySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBarangaySystem.DatabaseContext
{
    public class ebsDbContext: DbContext
    {
        public ebsDbContext(DbContextOptions<ebsDbContext> options): base(options)
        {

        }

        public DbSet<system_login_access> SYSTEM_LOGIN_ACCESS { get; set; }
    }
}
