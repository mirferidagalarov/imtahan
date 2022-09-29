using Imtahan_Proqrami.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.DatabaseContext
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Exam> Exams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lesson>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Pupil>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Exam>().HasQueryFilter(m => !m.IsDeleted);
        }

    }
}
