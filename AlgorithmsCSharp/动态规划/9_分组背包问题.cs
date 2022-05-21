namespace _9_分组背包问题
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            const int N = 110;
            int[] dp = new int[N];
            int[] v = new int[N], w = new int[N];
            for (int i = 0; i < n; i++)
            {
                int s = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < s; j++)
                {
                    v[j] = Convert.ToInt32(Console.ReadLine());
                    w[j] = Convert.ToInt32(Console.ReadLine());
                }

                for (int j = m; j >= 0; j--)
                {
                    for (int k = 0; k < s; k++)
                    {
                        if (v[k] <= j)
                        {
                            dp[j] = Math.Max(dp[j], dp[j - v[k]] + w[k]);
                        }
                    }
                }
            }

            Console.WriteLine(dp[m]);
        }
    }
}
