using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AntonovDI.Sprint6.Task2.V10.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFunctionValues()
        {
            var calc = new DataService();
            double[] actual = calc.GetMassFunction(-5, 5);

            double[] expected = actual; 
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01, $"Mismatch at index {i}");
            }
        }
    }
}
