using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric_Sequence_Calculator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Sequence_Calculator.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        List<string> actual = new List<string>();
        HomeController ctrl = new HomeController();

        [TestMethod()]
        public void getFibonacciListTest()
        {

            actual = ctrl.getFibonacciList(5);
            var expected = new List<string>{"1","1","2","3","5" };
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void getNumericListTest()
        {
            actual = ctrl.getNumericList(10);
            var expected = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void getEvenNumbersListTest()
        {
            actual = ctrl.getEvenNumbers(10);
            var expected = new List<string> { "2", "4", "6", "8", "10" };
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void getOddNumbersListTest()
        {
            actual = ctrl.getOddNumbers(10);
            var expected = new List<string> { "1", "3", "5", "7", "9" };
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void replaceMultiplesOf3and5Test()
        {
            actual = ctrl.replaceMultiplesOf3and5(15);
            var expected = new List<string> { "1", "2", "C", "E", "C", "7", "8", "C", "E", "11", "C", "13", "14", "Z" };
        }
    }
}