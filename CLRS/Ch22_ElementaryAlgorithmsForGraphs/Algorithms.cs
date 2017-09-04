using System.Collections.Generic;

namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs {
    class Algorithms {
        public static void BreadthFirstSearch(GraphAsAdjacencyList graph, Vertex source) {
            foreach(var vertex in graph.Vertices) {
                vertex.Color = VertexColor.White;
                vertex.Distance = -1;
                vertex.Predecessor = null;
            }
            source.Distance = 0;
            source.Color = VertexColor.Gray;
            source.Predecessor = null;

            var queue = new Queue<Vertex>();

            queue.Enqueue(source);
            while (queue.Count > 0) {
                var u = queue.Dequeue();
                foreach (var v in graph.AdjacencyList[u.Index]) {
                    if (v.Color == VertexColor.White) {
                        v.Color = VertexColor.Gray;
                        v.Distance = u.Distance + 1;
                        v.Predecessor = u;
                        queue.Enqueue(v);
                    }
                }
                u.Color = VertexColor.Black;
            }
        }
    }
}
