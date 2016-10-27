using AutomatedTellerMaching.Models;
using System.Linq;

namespace AutomatedTellerMaching.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;
        public CheckingAccountService(ApplicationDbContext dbcontext)
        {
            db = dbcontext;
        }
        public void CreateCheckingAccount(string firstName, string lastName, string userId, decimal initialBalance)
        {
            var accountNumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount
            {
                FirstName = firstName,
                LastName = lastName,
                AccountNumber = accountNumber,
                Balance = 0,
                ApplicationUserId = userId
            };
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();
        }

    }
}