using NUnit.Framework;
using System.IO;
using Lab5;

namespace Lab5.Tests
{
    public class Tests
    {


        [Test]
        public void Test1()
        {
            FileReader reader = new FileReader();
            FileWriter writer = new FileWriter();
            writer.WriteArrayInAscOrder(reader.ReadFile(Path.Combine(TestContext.CurrentContext.TestDirectory, "ArrayToBeSorted.txt")), Path.Combine(TestContext.CurrentContext.TestDirectory, "SortedArray.txt"));
            Assert.Pass();
        }
    }
}