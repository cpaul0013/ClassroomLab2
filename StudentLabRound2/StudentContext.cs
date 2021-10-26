using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLabRound2
{
    class StudentContext : DbContext
    {
        public DbSet<Student> students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ClassroomLabDB;Integrated Security=SSPI;");
        }
    }
}
