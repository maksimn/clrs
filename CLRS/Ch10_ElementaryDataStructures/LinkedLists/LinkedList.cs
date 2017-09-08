namespace Books.CLRS.Ch10_ElementaryDataStructures.LinkedLists {
    public class LinkedList<T> {
        public ListNode Head { get; private set; }

        public ListNode Search(int key) {
            var x = Head;
            
            while (x != null && x.Key != key) {
                x = x.Next;
            }

            return x;
        }

        public void Insert(ListNode node) {
            node.Next = Head;
            if(Head != null) {
                Head.Prev = node;
            }
            Head = node;
            node.Prev = null;
        }

        public void Delete(ListNode node) {
            if (node.Prev != null) {
                node.Prev.Next = node.Next;
            } else {
                Head = node.Next;
            }
            if (node.Next != null) {
                node.Next.Prev = node.Prev;
            }
        }
    }
}
