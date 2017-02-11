using System;

namespace Books.CLRS.Ch10.Trees {
    public class BinaryTree {
        private BinaryTreeNode _root;

        public BinaryTreeNode CreateRoot(int key, object value = null) {
            _root = new BinaryTreeNode(key, value);
            return _root;
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
    }
}
