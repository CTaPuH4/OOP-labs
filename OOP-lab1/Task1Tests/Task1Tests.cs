using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task1.Tests
{
    [TestClass()]
    public class Task1Tests
    {
        [TestMethod()]
        public void EqualityTest()
        {
            Task1 test = new Task1(-3, 1);
            Task1 test1 = new Task1(-3, 1);
            Assert.IsTrue(test == test1);
        }

        [TestMethod()]
        public void AddititonTest()
        {
            Task1 test = new Task1(3, 1);
            Task1 test1 = new Task1(-3, 1);
            Task1 result = new Task1(0, 1000);
            Assert.IsTrue(test + test1 == result);
        }
    }
}