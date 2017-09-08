using NUnit.Framework;

namespace Books.CLRS.Ch10_ElementaryDataStructures.StacksNQueues.Tests {
    [TestFixture]
    class StackTests {
        [Test]
        public void Exercise_10_1_1() {
            var stack = new Stack<int>();
            stack.Push(4);
            stack.Push(1);
            stack.Push(3);
            var res1 = stack.Pop();
            stack.Push(8);
            var res2 = stack.Pop();

            Assert.AreEqual(3, res1);
            Assert.AreEqual(8, res2);
        }
    }
}
