using System.Collections.Generic;

namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs {
    class Graph {
        public Vertex[] Vertices { get; set; }

        public void BreadthFirstSearch(Vertex source) {
            foreach (var vertex in Vertices) {
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
                foreach (var v in u.AdjacencyList) {
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
