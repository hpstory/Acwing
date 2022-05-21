namespace _4_多重背包问题
{
    class Program
    {
        static void Main()
        {
            //const int N = 110;
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //int[,] dp = new int[N, N];
            //for (int i = 1; i <= n; i++)
            //{
            //    int v = Convert.ToInt32(Console.ReadLine());
            //    int w = Convert.ToInt32(Console.ReadLine());
            //    int s = Convert.ToInt32(Console.ReadLine());
            //    for (int j = 0; j <= m; j++)
            //    {
            //        for (int k = 0; k <= s && v * k <= j; k++)
            //        {
            //            dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - v * k] + w * k);
            //        }
            //    }
            //}

            //Console.WriteLine(dp[n, m]);

            const int N = 110;
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] dp = new int[N];
            for (int i = 1; i <= n; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                int w = Convert.ToInt32(Console.ReadLine());
                int s = Convert.ToInt32(Console.ReadLine());
                for (int j = m; j >= 0; j--)
                {
                    for (int k = 0; k <= s && v * k <= j; k++)
                    {
                        dp[j] = Math.Max(dp[j], dp[j - v * k] + w * k);
                    }
                }
            }

            Console.WriteLine(dp[m]);
        }
    }
}
