namespace _798_差分矩阵
{
    class Program
    {
        static int[,] b;
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n + 10, m + 10];
            b = new int[n + 10, m + 10];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    Insert(i, j, i, j, a[i, j]);
                }
            }

            while (q-- > 0)
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                Insert(x1, y1, x2, y2, c);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    a[i, j] = a[i - 1, j] + a[i, j - 1] - a[i - 1, j - 1] + b[i, j];
                    // b[i, j] = b[i, j] + b[i - 1, j] + b[i, j - 1] - b[i - 1, j - 1];
                    Console.Write(a[i, j] + " ");
                }

                Console.Write("\n");
            }
        }

        private static void Insert(int x1, int y1, int x2, int y2, int c)
        {
            b[x1, y1] += c;
            b[x2 + 1, y1] -= c;
            b[x1, y2 + 1] -= c;
            b[x2 + 1, y2 + 1] += c;
        }
    }
}
