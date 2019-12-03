using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
namespace UnitTestProject1credit2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //unit test method  
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange  
            double beginningBalance = 11.99;
            double CreditAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act  
            account.Debit(CreditAmount);

            // assert is handled by ExpectedException  
        }

    }
}
