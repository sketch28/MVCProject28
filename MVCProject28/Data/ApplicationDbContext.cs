using Microsoft.EntityFrameworkCore;
using MVCProject28.Models;
using System.Collections.Generic;

namespace MVCProject28.Data
{
    public class ApplicationDbContext : DbContext    
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public IEnumerable<Expense> Expense { get; internal set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
    }
}
