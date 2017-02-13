using System;
using System.Collections.Generic;

namespace Books.CLRS.Ch10.Trees {
    public class BinaryTree {
        private BinaryTreeNode _root;

        public BinaryTree(BinaryTreeNode rootNode) {
            _root = rootNode;
        }

        public void AppendLeftNode(BinaryTreeNode node, BinaryTreeNode nodeToAppend) {
            nodeToAppend.Parent = node;
            node.Left = nodeToAppend;
        }

        public void AppendRightNode(BinaryTreeNode node, BinaryTreeNode nodeToAppend) {
            nodeToAppend.Parent = node;
            node.Right = nodeToAppend;
        }

        public void TraverseRecursive(Action<BinaryTreeNode> actionForNode) {
            TraverseRecursive(_root, actionForNode);
        }

        private void TraverseRecursive(BinaryTreeNode node, 
                                       Action<BinaryTreeNode> actionForNode) {
            if (actionForNode == null) {
                throw new ArgumentException(
                    "The actionForNode parameter must be set as not null value"
                );
            }

            actionForNode(node);

            if (node.Left != null) {
                TraverseRecursive(node.Left, actionForNode);
            }
            if (node.Right != null) {
                TraverseRecursive(node.Right, actionForNode);
            }
        }

        public void TraverseUsingStackNonRecursive(Action<BinaryTreeNode> actionForNode) {
            var node = _root;
			//keep the nodes in the path that are waiting to be visited
            var stack = new Stack<BinaryTreeNode>();

			//first node to be visited will be the left one
            while (node != null) {
                stack.Push(node);
                node = node.Left;
            }

			// traverse the tree
            while (stack.Count > 0) {
			    // visit the stack top node
                node = stack.Pop();
                actionForNode(node);

                if (node.Right != null) {
                    node = node.Right;
					// the next node to be visited is the leftmost
                    while (node != null) {
                        stack.Push(node);
                        node = node.Left;
                    }
                }
            }
        }
    }
}
