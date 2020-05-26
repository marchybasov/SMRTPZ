using System;
using Xunit;
using Lab6;
using System.IO;

namespace Lab6.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string file = @"D:/test.txt";
            string file2 = @"D:/test1.txt";
            StreamReader outputStream = new StreamReader(file);
            StreamWriter inputStream = new StreamWriter(file2, false);
            StreamEncryptor encryptor = new StreamEncryptor(outputStream, inputStream);
           
        }
    }
}
