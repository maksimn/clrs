using NUnit.Framework;
using System.Collections.Generic;

namespace Books.CLRS.Ch06_HeapSort.Tests {
    [TestFixture]
    class HeapSortTests {
        class IntAscComparer : IComparer<int> {
            public int Compare(int x, int y) {
                return x - y;
            }
        }

        [Test]
        public void GenericListSorting() {
            IList<int> list = new List<int>() { 34, 33, 1, 5, 7, 8, 10, 11, 4, 7 };

            list.HeapSort(new IntAscComparer());

            bool isCorrect = true;
            for (var i = 0; i < list.Count - 1; i++) {
                if (list[i] > list[i + 1]) {
                    isCorrect = false;
                    break;
                }
            }

            Assert.IsTrue(isCorrect);
        }

        [Test]
        public void ArraySorting() {
            int[] list = new int[] { 34, 33, 1, 5, 7, 8, 10, 11, 4, 7 };

            list.HeapSort(new IntAscComparer());

            bool isCorrect = true;
            for (var i = 0; i < list.Length - 1; i++) {
                if (list[i] > list[i + 1]) {
                    isCorrect = false;
                    break;
                }
            }

            Assert.IsTrue(isCorrect);
        }
    }
}
