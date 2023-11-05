using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checking_Acount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_Acount.Tests
{
    [TestClass()]
    public class WithdrowTests
    {
        [TestMethod()]
        public void Checking_AccountWithdrowTestSuccess(double amount, double _balance)
        {
             // Arrange
            Checking testChecking = new Checking(500);
            double amountToWithdraw = 200;
            double expectedResult = 300;

            // Act
            testChecking.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreEqual(expectedResult, testChecking);
            //Assert.Fail();
        }

        [TestMethod()]
        public void Checking_AccountWithdrowTestFail(double amount, double _balance)
        {
            // Arrange
            Checking testChecking = new Checking(500);
            double amountToWithdraw = 200;
            double notExpectedResult = 500;

            // Act
            testChecking.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreNotEqual(notExpectedResult, testChecking);
            //Assert.Fail();
        }
    }
}