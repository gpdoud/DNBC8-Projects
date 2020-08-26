using System;
using System.Collections.Generic;
using System.Text;
using EntityFrameworkCoreTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreTest {
    
    public class AppDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            if(!options.IsConfigured) {
                options.UseLazyLoadingProxies();
                options.UseSqlServer(@"server=localhost\sqlexpress;database=TestEfDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Customer>(e => {
                e.ToTable("Customers");
                e.HasKey(x => x.Id);
                e.Property(x => x.Name).HasMaxLength(30).IsRequired();
            });
        }
    }
}
