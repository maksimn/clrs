using System;
using System.Collections.Generic;

namespace Books.CLRS.Ch10_ElementaryDataStructures.StacksNQueues {
    public class Stack<T> {
        private List<T> array = new List<T>();
        private int top = -1;

        public void Push(T x) {
            if (top == array.Count - 1) {
                array.Add(x); 
                top++;
            } else {
                top++;
                array[top] = x;
            }
        }

        public T Pop() {
            if (StackEmpty()) {
                throw new InvalidOperationException("You cannot pop element from an empty stack.");
            }

            top--;
            return array[top + 1];
        }

        public bool StackEmpty() {
            return top == -1;
        }
    }
}
