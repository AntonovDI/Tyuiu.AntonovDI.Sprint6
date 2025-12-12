using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AntonovDI.Sprint6.Task0.V2.Lib;
using System;

namespace Tyuiu.AntonovDI.Sprint6.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc_Valid()
        {
            var calc = new DataService();
            var res = calc.Calculate(3);
            Assert.AreEqual(6.425, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calc_Invalid()
        {
            var calc = new DataService();
            calc.Calculate(1);
        }
    }
}
