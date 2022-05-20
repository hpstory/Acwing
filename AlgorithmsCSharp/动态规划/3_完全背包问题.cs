namespace _3_完全背包问题
{
    class Program
    {
        //static void Main()
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int m = Convert.ToInt32(Console.ReadLine());
        //    const int N = 1010;
        //    int[] v = new int[N];
        //    int[] w = new int[N];
        //    int[,] dp = new int[N, N];

        //    for (int i = 1; i <= n; i++)
        //    {
        //        v[i] = Convert.ToInt32(Console.ReadLine());
        //        w[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 0; j <= m; j++)
        //        {
        //            dp[i, j] = dp[i - 1, j];
        //            if (j >= v[i])
        //            {
        //                dp[i, j] = Math.Max(dp[i, j], dp[i, j - v[i]] + w[i]);
        //            }
        //        }
        //    }

        //    Console.WriteLine(dp[n, m]);
        //}

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            const int N = 1010;
            int[] v = new int[N];
            int[] w = new int[N];
            int[] dp = new int[N];

            for (int i = 1; i <= n; i++)
            {
                v[i] = Convert.ToInt32(Console.ReadLine());
                w[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = v[i]; j <= m; j++)
                {
                    dp[j] = Math.Max(dp[j], dp[j - v[i]] + w[i]);
                }
            }

            Console.WriteLine(dp[m]);
        }
    }
}
