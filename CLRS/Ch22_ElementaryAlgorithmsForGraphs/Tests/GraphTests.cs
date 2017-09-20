﻿using NUnit.Framework;

namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs.Tests {
    [TestFixture]
    class GraphTests {
        [Test]
        public void BreadthFirstSearch_Test1() {
            var vertex1 = new Vertex() { Key = 1 };
            var vertex2 = new Vertex() { Key = 2 };
            var vertex3 = new Vertex() { Key = 3 };
            var vertex4 = new Vertex() { Key = 4 };
            var vertex5 = new Vertex() { Key = 5 };

            vertex1.AdjacencyList = new Vertex[] { vertex2, vertex5 };
            vertex2.AdjacencyList = new Vertex[] { vertex1, vertex5, vertex3, vertex4 };
            vertex3.AdjacencyList = new Vertex[] { vertex2, vertex4 };
            vertex4.AdjacencyList = new Vertex[] { vertex2, vertex5, vertex3 };
            vertex5.AdjacencyList = new Vertex[] { vertex1, vertex2, vertex4 };

            var graph = new Graph() {
                Vertices = new Vertex[] { vertex1, vertex2, vertex3, vertex4, vertex5 }
            };

            graph.BreadthFirstSearch(vertex1);

            foreach (var v in graph.Vertices)
                Assert.AreEqual(VertexColor.Black, v.Color);
        }
    }
}
