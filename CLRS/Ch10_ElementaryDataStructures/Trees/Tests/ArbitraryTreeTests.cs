using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace Books.CLRS.Ch10_ElementaryDataStructures.Trees.Tests {
    [TestFixture]
    class ArbitraryTreeTests {
        [Test]
        public void Traverse() {
            //                        1
            //                       / 
            //                      2 --  3 --  4
            //                    /     /
            //                  5     6 -- 7 -- 8
            //                                 /
            //                                9 -- 10
            var root = new ArbitraryTreeNode() { Key = 1 };
            var tree = new ArbitraryTree(root);
            var node2 = new ArbitraryTreeNode() { Key = 2 };
            var node3 = new ArbitraryTreeNode() { Key = 3 };
            var node4 = new ArbitraryTreeNode() { Key = 4 };
            var node5 = new ArbitraryTreeNode() { Key = 5 };
            var node6 = new ArbitraryTreeNode() { Key = 6 };
            var node7 = new ArbitraryTreeNode() { Key = 7 };
            var node8 = new ArbitraryTreeNode() { Key = 8 };
            var node9 = new ArbitraryTreeNode() { Key = 9 };
            var node10 = new ArbitraryTreeNode() { Key = 10 };

            tree.AppendLeftChild(root, node2);
            tree.AppendRightSibling(node2, node3);
            tree.AppendRightSibling(node3, node4);
            tree.AppendLeftChild(node2, node5);
            tree.AppendLeftChild(node3, node6);
            tree.AppendRightSibling(node6, node7);
            tree.AppendRightSibling(node7, node8);
            tree.AppendLeftChild(node8, node9);
            tree.AppendRightSibling(node9, node10);

            var treeNodeKeys = new HashSet<int>();

            tree.Traverse(node => treeNodeKeys.Add(node.Key));

            Assert.AreEqual(10, treeNodeKeys.Count);
        }
    }
}
