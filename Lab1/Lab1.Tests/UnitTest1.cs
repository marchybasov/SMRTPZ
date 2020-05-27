
using System;
using Xunit;
using Lab1;

namespace Lab1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Can_Find_LessThanAvg()
        {
             string[] testArr = new string[] {"12","123","1234","12345","123456" };
            IStringHandler stringHandler = new StringHandler();
            string[] outputArr =  stringHandler.DefineLessThanAvrg(testArr);

            Assert.Equal(2, outputArr.Length);
            Assert.Equal("123", outputArr[1]);


        }

        [Fact]
        public void Can_Find_SmallestWords()
        {
            string testString =  "  home12 home1 home2 home123 home1234 home3 home123456";
            IStringHandler stringHandler = new StringHandler();
       
            string[] outputArr = stringHandler.FindSmallestWords(testString);

            Assert.Equal(3, outputArr.Length);
            Assert.Equal("home2", outputArr[1]);
        }
    }
}
