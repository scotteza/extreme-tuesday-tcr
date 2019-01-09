using NUnit.Framework;

namespace ExtremeTuesday.Tests
{
    [TestFixture]
    internal class FibonacciShould
    {
        protected internal Fibonacci _fibonacci;

        [SetUp]
        public void SetUp()
        {
            _fibonacci = new Fibonacci();
        }

        [Test]
        public void Return_Zero_On_Zero_Input()
        {
            Assert.That(_fibonacci.Of(0), Is.EqualTo(0));
        }

        [Test]
        public void Return_Zero_On_One_Input()
        {
            Assert.That(_fibonacci.Of(1), Is.EqualTo(1));
        }

        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,1)]
        public void Return_One_For_Two_input(int input, int expected)
        {
            Assert.That(_fibonacci.Of(input), Is.EqualTo(expected));
        }
 
    }
}
