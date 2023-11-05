using Microsoft.VisualStudio.TestTools.UnitTesting;
using Saving_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account.Tests
{
    [TestClass()]
    public class WithdrowTests
    {
        [TestMethod()]
        public void Saving_AccountWithdrowTestSuccess()
        {
            // Arrange
           Saving testSaving = new Saving(500);
            double amountToWithdraw = 200;
            double expectedResult = 300;

            // Act
            testSaving.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreEqual(expectedResult, testSaving);
            //Assert.Fail();
        
        }
        [TestMethod()]
        public void Saving_AccountWithdrowTestFail(double amount, double _balance)
        {
            // Arrange
            Saving testSaving = new Saving(500);
            double amountToWithdraw = 200;
            double notExpectedResult = 500;

            // Act
            testSaving.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreNotEqual(notExpectedResult, testSaving);
            //Assert.Fail();
        }
    }
}