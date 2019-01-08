using NUnit.Framework;

namespace ExtremeTuesday.Tests
{
    [TestFixture]
    internal class FibonacciShould
    {
        [Test]
        public void Return_Zero_On_Zero_Input()
        {
            var fibonacci = new Fibonacci();

            var result = fibonacci.Of(0);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
