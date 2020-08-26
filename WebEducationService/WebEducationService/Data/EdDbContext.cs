using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Models;

namespace WebEducationService.Data {

    public class EdDbContext : DbContext {

        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }
    
        public EdDbContext(DbContextOptions<EdDbContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Student>(e => {
                e.ToTable("Students");
                e.Property(x => x.Firstname).HasMaxLength(30).IsRequired();
                e.Property(x => x.Lastname).HasMaxLength(30).IsRequired();
            });
            builder.Entity<Class>(e => {
            });
        }

    }
}
