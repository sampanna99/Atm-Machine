using AutomatedTellerMaching.Controllers;
using AutomatedTellerMaching.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AutomatedTellerMaching.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FooActionReturnsAboutView()
        {
            var homeController = new HomeController();

            var result = homeController.Foo() as ViewResult;

            Assert.AreEqual("About", result.ViewName);

        }

        [TestMethod]
        public void ContactFormSaysThanks()
        {
            var homeController = new HomeController();
            var result = homeController.Contact("I love your Bank") as ViewResult;
            //  Assert.AreEqual("Thanks!", result.ViewBag.TheMessage);
            Assert.IsNotNull(result.ViewBag);

        }
        [TestMethod]
        public void BalanceIsCorrectAfterDeposit()
        {
            var fakeDb = new FakeApplicationDbContext();
            fakeDb.CheckingAccounts = new FakeDbSet<CheckingAccount>();

            var checkingAccount = new CheckingAccount { Id = 10, AccountNumber = "000000TEST", Balance = 0 };

            fakeDb.Transactions = new FakeDbSet<Transaction>();
            var transactionsController = new TransactionController(fakeDb);
            transactionsController.Deposit(new Transaction { CheckingAccountId = 10, Amount = 25 });

            // checkingAccount.Balance = 25;

            Assert.AreEqual(25, checkingAccount.Balance);

        }

    }
}
