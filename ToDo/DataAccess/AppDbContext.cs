using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entities;

namespace ToDo.DataAccess
{
    public class AppDbContext: DbContext
    {
        public DbSet<ToDoEntity> ToDoTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ToDo.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PK
            modelBuilder.Entity<ToDoEntity>().HasKey(c => c.id);

       
        }
    }
}
