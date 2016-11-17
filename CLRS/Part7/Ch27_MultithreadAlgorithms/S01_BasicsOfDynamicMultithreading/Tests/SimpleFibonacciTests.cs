using NUnit.Framework;
using static Books.CLRS.Part7.Ch27_MultithreadAlgorithms.S01_BasicsOfDynamicMultithreading.SimpleFibonacci;

namespace Books.CLRS.Part7.Ch27_MultithreadAlgorithms.S01_BasicsOfDynamicMultithreading.Tests {
    [TestFixture]
    class SimpleFibonacciTests {
        [Test]
        public void FibTest() {
            var result = Fib(4);

            Assert.AreEqual(3, result);
        }
    }
}
