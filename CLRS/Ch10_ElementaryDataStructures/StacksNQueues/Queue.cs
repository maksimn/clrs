using System;
using System.Collections.Generic;

namespace Books.CLRS.Ch10_ElementaryDataStructures.StacksNQueues {
    public class Queue<T> {
        private List<T> array = new List<T>();
        private int head = 0; // индекс головного элемента
        private int tail = 0; // индекс добавления нового элемента

        public void Enqueue(T x) {
            array.Add(x);
            tail++;
        }

        public T Dequeue() {
            if (head == tail) {
                throw new InvalidOperationException();
            }

            var x = array[head];
            array[head] = default(T);
            head++;
            return x;
        }
    }
}
