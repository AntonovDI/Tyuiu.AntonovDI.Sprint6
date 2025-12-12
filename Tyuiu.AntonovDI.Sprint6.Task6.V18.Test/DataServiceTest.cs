using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AntonovDI.Sprint6.Task6.V18.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_ValidCase()
        {
            string testPath = Path.Combine(Path.GetTempPath(), "TestFileTask6V18.txt");
            string testData = "programming language C sharp\nnetworking protocols internet\nwindows operating systems\nnatural language processing\nnumber theory mathematics";
            File.WriteAllText(testPath, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(testPath);

            string expected = "programming language networking internet windows operating natural language processing number";
            Assert.AreEqual(expected, result);

            File.Delete(testPath);
        }
    }
}
