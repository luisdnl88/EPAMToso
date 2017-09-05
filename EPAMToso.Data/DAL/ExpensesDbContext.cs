using EPAMToso.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAMToso.Data.DAL
{
    public class ExpensesDbContext : DbContext
    {

    public DbSet<Roomie> Roomies { get; set; }
    public DbSet<Expenses> Expenses { get; set; }
    public DbSet<House> Houses { get; set; }

    public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
      : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Expenses>().ToTable("Expense");
      modelBuilder.Entity<Roomie>().ToTable("Roomie");
      modelBuilder.Entity<House>().ToTable("House");

    }


  }
}
 