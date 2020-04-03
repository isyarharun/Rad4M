using Application.Model.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Context
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ToDo;Trusted_Connection=True;");
        }
    }
}
