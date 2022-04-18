using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlaneTicketsApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using PlaneTicketsApp.Models;
using PlaneTicketsApp.Domain;

namespace PlaneTicketsApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Reserve> Reservations { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<PlaneTicketsApp.Models.ClientBindingAllViewModel> ClientBindingAllViewModel { get; set; }
        public DbSet<PlaneTicketsApp.Models.OrderAllVM> OrderAllVM { get; set; }
        //public DbSet<PlaneTicketsApp.Models.FlightBindingAllViewModel> FlightBindingAllViewModel { get; set; }
    }
}
