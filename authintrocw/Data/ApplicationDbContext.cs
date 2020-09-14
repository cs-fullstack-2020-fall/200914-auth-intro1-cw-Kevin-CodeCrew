using System;
using System.Collections.Generic;
using System.Text;
using authintrocw.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace authintrocw.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
    // Add CustomerModel dbset
    public DbSet<CustomerModel> customers {get;set;} 
    }

}
