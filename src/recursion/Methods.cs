namespace recursion
{
    public static class Methods
    {
        public static int Iterative(int n)
        {
            int result = 0;

            for (var i = 0; i < n; i++)
            {
                result += 2;
            }
            return result / 2;
        }
        
        public static int Recursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return 1 + Recursive(n - 1);
        }
    
    
        public static int TailRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return TailRecursiveInternal(0, n);
        }

        private static int TailRecursiveInternal(int acc, int n)
        {
            if (n == 0)
            {
                return acc;
            }

            return TailRecursiveInternal(acc + 1, n - 1);
        }
    }
}
