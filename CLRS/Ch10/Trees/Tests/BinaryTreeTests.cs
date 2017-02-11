using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace Books.CLRS.Ch10.Trees.Tests {
    [TestFixture]
    class BinaryTreeTests {
        private BinaryTree binaryTree;

        [SetUp]
        public void Setup() {
            // Создать дерево с 10-ю элементами
            //              key = 18 
            //              /      \
            //      key = 12        key = 10
            //      /     \           /    \ 
            // key = 7 key = 4    key = 2   key = 21
            //           /
            //      key = 5
            //      /     \
            // key = 15 key = 14
            binaryTree = new BinaryTree();

            var root = binaryTree.CreateRoot(18);

            var leftSubNode = root.AppendLeftNode(12);
            var rightSubNode = root.AppendRightNode(10);

            var nodeKey7 = leftSubNode.AppendLeftNode(7);
            var nodeKey4 = leftSubNode.AppendRightNode(4);

            var nodeKey2 = rightSubNode.AppendLeftNode(2);
            var nodeKey21 = rightSubNode.AppendRightNode(21);

            var nodeKey5 = nodeKey4.AppendLeftNode(5);

            var nodeKey15 = nodeKey5.AppendLeftNode(15);
            var nodeKey14 = nodeKey5.AppendRightNode(14);
        }

        [Test]
        public void TraverseRecursive_AllBinTreeElementsTraversed() {
            var nodeList = new List<BinaryTreeNode>();

            binaryTree.TraverseRecursive(node => nodeList.Add(node));

            Assert.AreEqual(10, nodeList.Count);
            Assert.IsTrue(nodeList.Exists(node => node.Key == 18));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 12));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 10));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 7));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 4));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 2));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 21));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 5));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 15));
            Assert.IsTrue(nodeList.Exists(node => node.Key == 14));
        }

        [Test]
        public void TraverseRecursive_actionParameterIsNull_ThrowsException() {
            Assert.Catch<ArgumentException>(() => binaryTree.TraverseRecursive(null));
        }
    }
}
