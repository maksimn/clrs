using NUnit.Framework;
using System.Collections.Generic;

namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs.Tests {
    [TestFixture]
    class BreadthFirstSearchTests {
        [Test]
        public void Test1() {
            var vertices = new Vertex[] {
                new Vertex() { Index = 0 },
                new Vertex() { Index = 1 },
                new Vertex() { Index = 2 },
                new Vertex() { Index = 3 },
                new Vertex() { Index = 4 }
            };
            var adjacencyList = new List<Vertex>[] {
                new List<Vertex>() { vertices[1], vertices[4] },
                new List<Vertex>() { vertices[0], vertices[4], vertices[2], vertices[3] },
                new List<Vertex>() { vertices[1], vertices[3] },
                new List<Vertex>() { vertices[1], vertices[4], vertices[2] },
                new List<Vertex>() { vertices[0], vertices[1], vertices[3] }
            };
            var graph = new GraphAsAdjacencyList() {
                Vertices = vertices,
                AdjacencyList = adjacencyList
            };
            var source = vertices[0];

            Algorithms.BreadthFirstSearch(graph, source);

            Assert.IsTrue(false);
        }
    }
}
