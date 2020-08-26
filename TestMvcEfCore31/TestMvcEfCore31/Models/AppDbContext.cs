using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestMvcEfCore31.Models {

    public class AppDbContext : DbContext {

        public virtual DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Student>(e => {
                e.ToTable("Students");
                
                e.HasKey(x => x.Id);
                
                e.Property(x => x.Code).HasMaxLength(30).IsRequired();
                e.Property(x => x.Name).HasMaxLength(30).IsRequired();
                e.Property(x => x.Tuition).HasColumnType("decimal(11,2)");
                
                e.HasIndex(x => x.Code).IsUnique();
            });
        }
    }
}
