using NUnit.Framework;

namespace ExtremeTuesday.Tests
{
    [TestFixture]
    internal class FibonacciShould
    {
        private Fibonacci _fibonacci;

        [SetUp]
        public void SetUp()
        {
            _fibonacci = new Fibonacci();
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void Calculate_Fibonacci_Value_For_A_Number(int input, int expected)
        {
            Assert.That(_fibonacci.Of(input), Is.EqualTo(expected));
        }

    }
}
