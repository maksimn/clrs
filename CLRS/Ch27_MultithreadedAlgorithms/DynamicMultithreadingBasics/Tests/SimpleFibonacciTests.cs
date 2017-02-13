using NUnit.Framework;
using static Books.CLRS.Ch27.DynamicMultithreadingBasics.SimpleFibonacci;

namespace Books.CLRS.Ch27.DynamicMultithreadingBasics.Tests {
    [TestFixture]
    class SimpleFibonacciTests {
        [Test]
        public void FibTest() {
            var result = Fib(4);

            Assert.AreEqual(3, result);
        }
    }
}
