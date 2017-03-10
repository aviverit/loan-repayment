using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoanRepaymentTestSuite
{
    [TestClass]
    public class StudentLoanTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double expected = 1.00;
            StudentLoan sL = new StudentLoan();
            //Act
            double actual = sL.getAmount();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class ParentLoanTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }

    [TestClass]
    public class EquityLoanTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }

    [TestClass]
    public class Four01KLoanTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
