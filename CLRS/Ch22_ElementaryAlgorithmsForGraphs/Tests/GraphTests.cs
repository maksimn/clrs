using NUnit.Framework;

namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs.Tests {
    [TestFixture]
    class GraphTests {
        Graph graph;
        Vertex vertex1;

        public void Graph_Init() {
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

            graph = new Graph() {
                Vertices = new Vertex[] { vertex1, vertex2, vertex3, vertex4, vertex5 }
            };
            this.vertex1 = vertex1;
        }

        [Test]
        public void BreadthFirstSearch_Test1() {
            Graph_Init();

            graph.BreadthFirstSearch(vertex1);

            foreach (var v in graph.Vertices)
                Assert.AreEqual(VertexColor.Black, v.Color);
        }

        [Test]
        public void DepthFirstSearch_Test1() {
            Graph_Init();

            graph.DepthFirstSearch();

            foreach (var v in graph.Vertices)
                Assert.AreEqual(VertexColor.Black, v.Color);
        }
    }
}
