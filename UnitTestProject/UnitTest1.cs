using BillCalcForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod()]
        [DataRow("1000", "10", "1100")]
        [DataRow("2000", "15", "2300")]
        
        public void BillCalcTest(string billString, string tipString, string expectedResultString)
        //public void BillCalcTest()
            {
            //multiple test cases
            var bill = decimal.Parse(billString);
            var tip = decimal.Parse(tipString);
            var expectedAmount = decimal.Parse(expectedResultString);

            var order = new Order();
            decimal amount = order.BillCalc(bill, tip);
            Assert.AreEqual(expectedAmount, amount);

            // single test case
            //var order = new Order();
            //decimal amount = order.BillCalc(1000, 10);
            //Assert.AreEqual(1100, amount);
        }
    }
}
