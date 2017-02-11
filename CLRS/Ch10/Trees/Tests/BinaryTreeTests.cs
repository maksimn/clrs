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
            var rootNode = new BinaryTreeNode(18, null);
            var nodeKey12 = new BinaryTreeNode(12, null);            
            var nodeKey10 = new BinaryTreeNode(10, null);            
            var nodeKey7 = new BinaryTreeNode(7, null);
            var nodeKey4 = new BinaryTreeNode(4, null);
            var nodeKey2 = new BinaryTreeNode(2, null);
            var nodeKey21 = new BinaryTreeNode(21, null);
            var nodeKey5 = new BinaryTreeNode(5, null);
            var nodeKey15 = new BinaryTreeNode(15, null);
            var nodeKey14 = new BinaryTreeNode(14, null);

            binaryTree = new BinaryTree(rootNode);
            binaryTree.AppendLeftNode(rootNode, nodeKey12);
            binaryTree.AppendRightNode(rootNode, nodeKey10);
            binaryTree.AppendLeftNode(nodeKey12, nodeKey7);
            binaryTree.AppendRightNode(nodeKey12, nodeKey4);
            binaryTree.AppendLeftNode(nodeKey10, nodeKey2);
            binaryTree.AppendRightNode(nodeKey10, nodeKey21);
            binaryTree.AppendLeftNode(nodeKey4, nodeKey5);
            binaryTree.AppendLeftNode(nodeKey5, nodeKey15);
            binaryTree.AppendRightNode(nodeKey5, nodeKey14);
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
