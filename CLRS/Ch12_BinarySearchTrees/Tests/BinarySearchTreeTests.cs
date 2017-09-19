using Books.CLRS.Ch10.Trees;
using NUnit.Framework;

namespace Books.CLRS.Ch12_BinarySearchTrees.Tests {
    [TestFixture]
    class BinarySearchTreeTests {
        [Test]
        public void Test1() {
            var bstree = new BinarySearchTree();
            var nodes = new BinaryTreeNode[] {
                new BinaryTreeNode(15, null),
                new BinaryTreeNode(6, null),
                new BinaryTreeNode(18, null),
                new BinaryTreeNode(3, null),
                new BinaryTreeNode(7, null),
                new BinaryTreeNode(17, null),
                new BinaryTreeNode(20, null),
                new BinaryTreeNode(2, null),
                new BinaryTreeNode(4, null),
                new BinaryTreeNode(13, null),
                new BinaryTreeNode(9, null)
            };
            foreach(var node in nodes) {
                bstree.Insert(node);
            }

            Assert.AreEqual(15, bstree.Root.Key);
        }
    }
}
