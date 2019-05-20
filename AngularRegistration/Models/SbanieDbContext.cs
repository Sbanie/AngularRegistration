using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;

using System.Data.Entity;

namespace AngularRegistration.Models
{
    public class SbanieDbContext : DbContext
    {
        public SbanieDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Register> Registers { get; set; }
       
    }
}