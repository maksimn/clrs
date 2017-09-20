namespace Books.CLRS.Ch22_ElementaryAlgorithmsForGraphs {
    enum VertexColor { White, Gray, Black }

    class Vertex {
        public int Key { get; set; }
        public VertexColor Color { get; set; }
        public Vertex Predecessor { get; set; }
        public int Distance { get; set; }
        public Vertex[] AdjacencyList { get; set; }
        public int TimeD { get; set; } // время открытия вершины
        public int TimeF { get; set; } // время завершения работы с вершиной 
    }
}
