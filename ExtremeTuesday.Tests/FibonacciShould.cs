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

        [Test]
        public void Return_One_For_Two_input()
        {
            Assert.That(_fibonacci.Of(2), Is.EqualTo(1));
        }
 

    }
}
