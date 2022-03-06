using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlaneTicketsApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using PlaneTicketsApp.Models;

namespace PlaneTicketsApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<PlaneTicketsApp.Models.ClientBindingAllViewModel> ClientBindingAllViewModel { get; set; }
    }
}
