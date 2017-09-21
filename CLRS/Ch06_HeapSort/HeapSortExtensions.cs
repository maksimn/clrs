using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Books.CLRS.Ch06_HeapSort {
    public static class HeapSortExtensions {
        // Функция поддержки свойства [невозрастающей/неубывающей] пирамиды для элемента i массива a
        private static void Heapify<T>(this IList<T> a, int i, IComparer<T> cmp) {
            int extremal = -1;
            int left = i == 0 ? 1 : 2 * i;
            int right = i == 0 ? 2 : 2 * i + 1;
            if (left < a.GetHeapSize() && cmp.Compare(a[left], a[i]) > 0) {
                extremal = left;
            } else {
                extremal = i;
            }
            if (right < a.GetHeapSize() && cmp.Compare(a[right], a[extremal]) > 0) {
                extremal = right;
            }
            if (extremal != i) {
                T temp = a[i];
                a[i] = a[extremal];
                a[extremal] = temp;
                Heapify(a, extremal, cmp);
            }
        }
        // Функция построения пирамиды по заданному массиву a
        private static void BuildHeap<T>(this IList<T> a, IComparer<T> cmp) {
            a.SetHeapSize(a.Count);
            for (int i = a.Count / 2; i >= 0; i--) {
                a.Heapify(i, cmp);
            }
        }
        // Алгоритм HeapSort
        public static void HeapSort<T>(this IList<T> a, IComparer<T> cmp) {
            a.BuildHeap(cmp);
            for (int i = a.Count - 1; i > 0; i--) {
                T temp = a[0];
                a[0] = a[i];
                a[i] = temp;
                a.SetHeapSize(a.GetHeapSize() - 1);
                a.Heapify(0, cmp);
            }
        }
        // To extend int[] arrays with 'HeapSize' "property" via getter and setter.
        private static readonly ConditionalWeakTable<object, IntObject> heapSize = 
                                                     new ConditionalWeakTable<object, IntObject>();

        private static int GetHeapSize<T>(this IList<T> a) {
            return heapSize.GetOrCreateValue(a).Value;
        }

        private static void SetHeapSize<T>(this IList<T> a, int val) {
            heapSize.GetOrCreateValue(a).Value = val;
        }

        private class IntObject {
            public int Value { get; set; }
        }
    }
}
