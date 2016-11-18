namespace Books.CLRS.Ch27.DynamicMultithreadingBasics {
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
