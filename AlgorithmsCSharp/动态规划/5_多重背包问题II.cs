namespace _5_多重背包问题II
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] dp = new int[2010];
            List<(int, int)> goods = new List<(int, int)>();
            for (int i = 1; i <= n; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                int w = Convert.ToInt32(Console.ReadLine());
                int s = Convert.ToInt32(Console.ReadLine());
                for (int k = 1; k <= s; k *= 2)
                {
                    s -= k;
                    goods.Add((v * k, w * k));
                }

                if (s > 0) goods.Add((v * s, w * s));
            }

            foreach (var good in goods)
            {
                for (int j = m; j >= good.Item1; j--)
                {
                    dp[j] = Math.Max(dp[j], dp[j - good.Item1] + good.Item2);
                }
            }

            Console.WriteLine(dp[m]);
        }
    }
}
