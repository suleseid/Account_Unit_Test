using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checking_Acount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saving_Account.Tests;

namespace Checking_Acount.Tests
{
    [TestClass()]
    public class DepositTests
    {

        [TestMethod()]
        public void Chacking_AccountDepositTestSuccess(double amount, double balance)
        {
            // Arrange
            Deposit testDeposit = new Deposit();
            double amountToDeposit = 500;
            double expectedResult = 500;

            // Act
             testDeposit.Chacking_AccountDeposit(amountToDeposit);

            // Assert
            Assert.AreEqual(expectedResult, testDeposit);
            //Assert.Fail();
        }

        [TestMethod()]
        public void Chacking_AccountDepositTestFaill(double amount, double balance)
        {
            // Arrange
            Deposit testDeposit = new Deposit();
            double amountToDeposit = 500;
            double notExpectedResult = 600;

            // Act
            testDeposit.Chacking_AccountDeposit(amountToDeposit);

            // Assert
            Assert.AreNotEqual(notExpectedResult, testDeposit);
            //Assert.Fail();
        }
    }
}