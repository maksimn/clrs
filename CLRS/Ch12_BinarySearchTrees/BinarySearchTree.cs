using Books.CLRS.Ch10.Trees;

namespace Books.CLRS.Ch12_BinarySearchTrees {
    public class BinarySearchTree {
        private BinaryTreeNode root;

        public BinarySearchTree(BinaryTreeNode rootNode = null) {
            root = rootNode;
        }

        public BinaryTreeNode Root {
            get {
                return root;
            }
        }

        public void Insert(BinaryTreeNode nodeToInsert) {
            BinaryTreeNode parentNodeForInsert = null;
            BinaryTreeNode nodeWhereInsert = root;
            while (nodeWhereInsert != null) {
                parentNodeForInsert = nodeWhereInsert;
                if (nodeToInsert.Key < nodeWhereInsert.Key) {
                    nodeWhereInsert = nodeWhereInsert.Left;
                } else {
                    nodeWhereInsert = nodeWhereInsert.Right;
                }
            }
            nodeToInsert.Parent = parentNodeForInsert;
            if (parentNodeForInsert == null) {
                root = nodeToInsert;
            } else if (nodeToInsert.Key < parentNodeForInsert.Key) {
                parentNodeForInsert.Left = nodeToInsert;
            } else {
                parentNodeForInsert.Right = nodeToInsert;
            }
        }

        public BinaryTreeNode Minimum(BinaryTreeNode node) {
            var x = node;
            while (x.Left != null)
                x = x.Left;
            return x;
        }

        public void Delete(BinaryTreeNode nodeToRemove) {
            if (nodeToRemove.Left == null)
                Transplant(nodeToRemove, nodeToRemove.Right);
            else if (nodeToRemove.Right == null)
                Transplant(nodeToRemove, nodeToRemove.Left);
            else {
                var y = Minimum(nodeToRemove.Right);
                if (y.Parent != nodeToRemove) {
                    Transplant(y, y.Right);
                    y.Right = nodeToRemove.Right;
                    y.Right.Parent = y;
                }
                Transplant(nodeToRemove, y);
                y.Left = nodeToRemove.Left;
                y.Left.Parent = y;
            }
        }

        // Заменяет поддерево с корнем в u поддеревом с корнем в v.
        public void Transplant(BinaryTreeNode u, BinaryTreeNode v) {
            if (u.Parent == null)
                root = v;
            else if (u == u.Parent.Left)
                u.Parent.Left = v;
            else 
                u.Parent.Right = v;

            if (v != null)
                v.Parent = u.Parent;

        }
    }
}
