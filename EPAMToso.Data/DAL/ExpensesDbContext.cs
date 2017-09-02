using EPAMToso.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAMToso.Data.DAL
{
    public partial class ExpensesDbContext : DbContext
    {

    public DbSet<Roomie> Roomies { get; set; }
    public DbSet<Expenses> Expenses { get; set; }

    public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
      : base(options)
    {}


    }
}
 