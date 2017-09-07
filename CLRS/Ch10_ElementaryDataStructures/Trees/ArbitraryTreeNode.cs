namespace Books.CLRS.Ch10_ElementaryDataStructures.Trees {
    public class ArbitraryTreeNode {
        public int Key { get; set; }
        public ArbitraryTreeNode Parent { get; set; }
        public ArbitraryTreeNode LeftChild { get; set; }
        public ArbitraryTreeNode RightSibling { get; set; }
        public object Value { get; set; }
    }
}
