namespace Books.CLRS.Ch10.Trees {
    public class BinaryTreeNode {
        public int Key { get; set; }
        public BinaryTreeNode Parent { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public object Value { get; set; }

        public BinaryTreeNode(int key, object value = null) {
            Key = key;
            Value = value;
        }

        public BinaryTreeNode AppendLeftNode(int key, object value = null) {
            Left = new BinaryTreeNode(key, value);
            Left.Parent = this;
            return Left;
        }

        public BinaryTreeNode AppendRightNode(int key, object value = null) {
            Right = new BinaryTreeNode(key, value);
            Right.Parent = this;
            return Right;
        }
    }
}
