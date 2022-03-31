using Microsoft.VisualStudio.TestTools.UnitTesting;

using Bank;
using System;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_Balance0_Return0()
        {
            //ARRANGE: Initialize data
            Account account = new Account();

            //ACT: Method calls
            double balance = account.Blance;

            //ASSERT: Test the result is as expected
            Assert.AreEqual(0, balance);

        }
        [TestMethod]
        public void Debit_AmountBiggerThanBalanceInsufficientException()
        {
            //ARRANGE
            Account account = new Account();
            account.Credit(200);

            //ASSERT                                                    //ACT
            Assert.ThrowsException<BalanceInsufficientException>(() => account.Debit(500));
        }
        [TestMethod]
        public void Credit_999OnBalance0_Returns999()
        {
            //ARRANGE: Initialize data
            Account account = new Account();

            //ACT: Method calls
            account.Credit(999);

            //ASSERT: Test the result is as expected
            Assert.AreEqual(999, account.Blance);
        }

        [TestMethod]
        public void Credit_NegativeAmount_ReturnsOutOfRangeException()
        {
            //ARRANGE
            Account account = new Account();

            //ASSERT                                                    //ACT
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Credit(-200));
        }
        
        
        
    }
}
