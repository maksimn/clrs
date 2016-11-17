namespace Books.CLRS.Part7.Ch27_MultithreadAlgorithms.S01_BasicsOfDynamicMultithreading {
    public static class SimpleFibonacci {
        public static int Fib(int n) {
            if (n <= 1) {
                return n;
            } else {
                int x = Fib(n - 1);
                int y = Fib(n - 2);
                return x + y;
            }
        }
    }
}
