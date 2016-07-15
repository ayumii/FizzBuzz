using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(67, "67")]
        public void TestCaseForFizzBuzzLoop(int number, string expected)
        {
            Assert.AreEqual(expected, FizzBuzz.GetOutput(number));
        }
    }
}
