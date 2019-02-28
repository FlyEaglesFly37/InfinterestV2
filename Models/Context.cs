using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Infinterest.Models
{
    public class Context : DbContext
    {
    // base() calls the parent class' constructor passing the "options" parameter along
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Broker> brokers { get; set; }
        public DbSet<Listing> listings { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<EventVendors> eventVendors { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // Configure User, Broker, and Vendor entity
        //     modelBuilder.Entity<User>()
        //                 .HasOptional(u => u.Vendor) // Mark Vendor and Broker properties optional in User entity
        //                 .HasOptional(u => u.Broker)
        //                 .WithRequired(b => b.User)
        //                 .WithRequired(v => v.User); // mark Broker and Vendor properties as required in User entity. Cannot save Broker or Vendor without User
        // }

    }
}
        