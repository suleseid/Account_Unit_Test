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
    public class DepositTests
    {
        [TestMethod()]
        public void Saving_AccountDepositTestSuccess(double amount, double balance)

        {
            // Arrange
            Deposit testDeposit = new Deposit(500);
            double amountToDeposit = 500;
            double expectedResult = 500;

            // Act
            testDeposit.Saving_AccountDeposit(amountToDeposit);

            // Assert
            Assert.AreEqual(expectedResult, testDeposit.Balance);
            //Assert.Fail();

        }

        [TestMethod()]
        public void Saving_AccountDepositTestFaill(double amount, double balance)
        {
            // Arrange
            Deposit testDeposit = new Deposit(500);
            double amountToDeposit = 500;
            double notExpectedResult = 500;

            // Act
            testDeposit.Saving_AccountDeposit(amountToDeposit);

            // Assert
            Assert.AreNotEqual(notExpectedResult, testDeposit.Balance);
            //Assert.Fail();
        }
    }
}