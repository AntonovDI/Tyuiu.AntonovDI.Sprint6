using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AntonovDI.Sprint6.Task4.V13.Lib;
using System;

namespace Tyuiu.AntonovDI.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFunctionValues()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
            double[] expected = new double[11];

            for (int i = 0; i < 11; i++)
            {
                double x = -5 + i;
                double d = Math.Cos(x) + 1;
                expected[i] = Math.Abs(d) < 0.000001
                    ? 0
                    : Math.Round(3 * x + 2 - x / d, 2, MidpointRounding.AwayFromZero);
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
