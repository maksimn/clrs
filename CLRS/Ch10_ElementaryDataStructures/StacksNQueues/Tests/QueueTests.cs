using NUnit.Framework;

namespace Books.CLRS.Ch10_ElementaryDataStructures.StacksNQueues.Tests {
    [TestFixture]
    class QueueTests {
        [Test]
        public void Exercise_10_1_3() {
            var queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(3);
            var res1 = queue.Dequeue();
            queue.Enqueue(8);
            var res2 = queue.Dequeue();

            Assert.AreEqual(4, res1);
            Assert.AreEqual(1, res2);
        }
    }
}
