using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AntonovDI.Sprint6.Task1.V11.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMass()
        {
            var calc = new DataService();
            var vals = calc.GetMassFunction(-5, 5);

            double[] wait =
            {
                -15.40, -13.31, -11.36, -8.00, -2.62,
                  1.83,   4.49,   6.78, 10.58, 17.38, 23.76
            };

            CollectionAssert.AreEqual(wait, vals);
        }
    }
}
