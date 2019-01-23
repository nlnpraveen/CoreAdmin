using CoreAdmin.Platform.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdmin.Security.Data
{
    public class SecurityContext : DbContext
    {
        public SecurityContext(DbContextOptions<SecurityContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.LastName).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.Username).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Password).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(200);           
            modelBuilder.Entity<User>().Ignore(u => u.AuditInfo);
            modelBuilder.Entity<User>().Ignore(u => u.Token);
            modelBuilder.Entity<User>().Ignore(u => u.Expires);
        }
    }
}
