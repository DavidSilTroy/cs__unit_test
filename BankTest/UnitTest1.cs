using Microsoft.VisualStudio.TestTools.UnitTesting;

using Bank;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE: Initialize data
            Account account = new Account();

            //ACT: Method calls
            double balance = account.Blance;

            //ASSERT: Test the result is as expected
            Assert.AreEqual(0, balance);

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
    }
}
