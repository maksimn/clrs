namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs {
    enum VertexColor { White, Gray, Black }

    class Vertex {
        // Индекс вершины в общем списке вершин
        public int Index { get; set; }
        public VertexColor Color { get; set; }
        public Vertex Predecessor { get; set; }
        public int Distance { get; set; }
    }
}
