namespace _796_子矩阵的和
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n + 1, m + 1];
            int[,] s = new int[n + 1, m + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    s[i, j] = s[i - 1, j] + s[i, j - 1] - s[i - 1, j - 1] + a[i, j];
                }
            }

            while (q-- > 0)
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s[x2, y2] - s[x1 - 1, y2] - s[x2, y1 - 1] + s[x1 - 1, y1 - 1]);
            }
        }
    }
}
