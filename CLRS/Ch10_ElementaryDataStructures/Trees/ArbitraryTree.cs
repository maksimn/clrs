using System;

namespace Books.CLRS.Ch10_ElementaryDataStructures.Trees {
    public class ArbitraryTree {
        private ArbitraryTreeNode rootNode;

        public ArbitraryTree(ArbitraryTreeNode root) {
            rootNode = root;
        }

        public void AppendLeftChild(ArbitraryTreeNode node, ArbitraryTreeNode nodeToAppend) {
            nodeToAppend.Parent = node;
            node.LeftChild = nodeToAppend;
        }

        public void AppendRightSibling(ArbitraryTreeNode node, ArbitraryTreeNode nodeToAppend) {
            nodeToAppend.Parent = node;
            node.RightSibling = nodeToAppend;
        }

        public void Traverse(Action<ArbitraryTreeNode> actionForNode) {
            Traverse(rootNode, actionForNode);
        }

        private void Traverse(ArbitraryTreeNode node, Action<ArbitraryTreeNode> actionForNode) {
            if (node == null) { 
                return;
            }

            actionForNode(node);
            Traverse(node.LeftChild, actionForNode);
            Traverse(node.RightSibling, actionForNode);
        }
    }
}