namespace recursion
{
    public static class Fibo
    {
        public static int Iterative(int n)
        {
            int result = 0;
            
            for ((int i, int first, int second) = (0, 0, 1); i <= n; (i, first, second) = (i+1, first+second, first)) {
                if (i == n)
                {
                    result = first;
                }
            }
            return result;
        }
        
        public static int TailRecursive(int n)
        {
            return TailRecursiveInternal(n, 0, 1);
        }

        private static int TailRecursiveInternal(int n, int first, int second)
        {
            if (n == 0)
            {
                return first;
            }

            return TailRecursiveInternal(n - 1, second, first + second);
        }

        public static int Recursive(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return Recursive(n - 2) + Recursive(n - 1);
        }
    }
}
