using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ExpenseService : IExpenseService
    {

        public int SaveExpense(Models.Expense expense)
        {
           ExpenseTrackerDBContext db = new ExpenseTrackerDBContext();
           db.Expenses.Add(expense);
           db.SaveChanges();

           return expense.ID;
        }

        public List<Models.Expense> GetExpensesByDate(DateTime fromDate, DateTime toDate)
        {
            ExpenseTrackerDBContext db = new ExpenseTrackerDBContext();
            List<Expense> expenses = db.Expenses.Where(e => e.Date >= fromDate && e.Date <= toDate).ToList();

            return expenses;
        }


        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }
    }
}
