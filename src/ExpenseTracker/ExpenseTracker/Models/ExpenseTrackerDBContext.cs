using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class ExpenseTrackerDBContext: DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
    }
}