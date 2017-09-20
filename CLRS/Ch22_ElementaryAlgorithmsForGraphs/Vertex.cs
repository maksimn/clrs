namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs {
    enum VertexColor { White, Gray, Black }

    class Vertex {
        public int Key { get; set; }
        public VertexColor Color { get; set; }
        public Vertex Predecessor { get; set; }
        public int Distance { get; set; }
        public Vertex[] AdjacencyList { get; set; }
    }
}
