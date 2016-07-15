using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCaseForFizzBuzz()
        {
            String actualResult = FizzBuzz.getOutput(30);
            String expectedResult = "FizzBuzz";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCaseForFizzBuzzLoop()
        {
            for (int i = 15; i < 100; i += 15)
            {
                String actualResult = FizzBuzz.getOutput(i);
                String expectedResult = "FizzBuzz";
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        [TestMethod]
        public void TestCaseForFizz()
        {
            String actualResult = FizzBuzz.getOutput(27);
            String expectedResult = "Fizz";
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestMethod]
        public void TestCaseForFizzLoop()
        {
            for (int i = 3; i < 100; i += 3)
            {
                if(i % 15 != 0)
                {
                    String actualResult = FizzBuzz.getOutput(i);
                    String expectedResult = "Fizz";
                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
        }
  
        [TestMethod]
        public void TestCaseForBuzz()
        {
            String actualResult = FizzBuzz.getOutput(100);
            String expectedResult = "Buzz";        
            Assert.AreEqual(expectedResult,actualResult);

        }

        [TestMethod]
        public void TestCaseForBuzzLoop()
        {
            for (int i = 5; i < 100; i += 5)
            {
                if (i%15 != 0)
                {
                    String actualResult = FizzBuzz.getOutput(5);
                    String expectedResult = "Buzz";
                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
        }

        [TestMethod]
        public void TestCaseForOthers()
        {
            String actualResult = FizzBuzz.getOutput(67);
            String expectedResult = "67";
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestMethod]
        public void TestCaseForOthersLoop()
        {
            for (int i = 1; i < 100; i += 1)
            {
                if (i % 15 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    String actualResult = FizzBuzz.getOutput(i);
                    String expectedResult = i.ToString();
                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
        }





    }
}
