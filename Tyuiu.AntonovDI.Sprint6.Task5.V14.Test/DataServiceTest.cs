using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AntonovDI.Sprint6.Task5.V14.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_FilterAndRound_Test()
        {
            string testPath = Path.Combine(Path.GetTempPath(), "TestFileTask5V14.txt");

            string testData = "8.5 13.0 11.49 9 10.0\n14.52 16 13.66 19 11 11.28";
            File.WriteAllText(testPath, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testPath);

            double[] expected = new double[]
            {
                13.0, 11.49, 10.0, 14.52, 16.0, 13.66, 19.0, 11.0, 11.28
            };

            CollectionAssert.AreEqual(expected, result);

            File.Delete(testPath);
        }
    }
}
