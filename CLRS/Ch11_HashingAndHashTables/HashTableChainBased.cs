using System.Collections.Generic;

namespace Books.CLRS.Ch11_HashingAndHashTables {
    public class HashTableChainBased<T> {
        private LinkedList<T>[] hashTable;

        private const int defaultSize = 100;
        private int size;

        public HashTableChainBased() {
            InstantiateHashTable(defaultSize);
        }

        public HashTableChainBased(int numCells) {
            InstantiateHashTable(numCells);
        }

        private void InstantiateHashTable(int size) {
            hashTable = new LinkedList<T>[size];
            for (var i = 0; i < hashTable.Length; i++) {
                hashTable[i] = new LinkedList<T>();
            }
            this.size = size;
        }

        private int GetIndexForHashTable(T value) {
            int index = value.GetHashCode() % size;
            return index > -1 ? index : -index;
        }

        public void Insert(T value) {
            int index = GetIndexForHashTable(value);
            hashTable[index].AddLast(value);
        }

        public void Delete(T value) {
            int index = GetIndexForHashTable(value);
            hashTable[index].Remove(value);
        }

        public bool Search(T value) {
            int index = GetIndexForHashTable(value);
            var node = hashTable[index].Find(value);
            return node != null;
        }
    }
}
