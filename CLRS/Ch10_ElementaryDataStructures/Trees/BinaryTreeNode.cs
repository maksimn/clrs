namespace Books.CLRS.Ch10.Trees {
    public class BinaryTreeNode {
        public int Key { get; set; }
        public BinaryTreeNode Parent { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public object Value { get; set; }

        public BinaryTreeNode(int key, object value) {
            Key = key;
            Value = value;
        }
    }
}
