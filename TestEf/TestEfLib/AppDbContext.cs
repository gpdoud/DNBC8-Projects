using System;
using Microsoft.EntityFrameworkCore;

namespace TestEfLib {
    public class AppDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if(!builder.IsConfigured) {
                builder.UseLazyLoadingProxies();
                builder.UseSqlServer(@"server=localhost\sqlexpress;database=DeleteMeDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Customer>(e => {
                e.ToTable("Customers");
                e.HasKey(x => x.Id);
            });
        }
    }
}
