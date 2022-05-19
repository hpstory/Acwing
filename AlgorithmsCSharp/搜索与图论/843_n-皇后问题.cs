namespace _843_n_皇后问题
{
    class Program
    {
        static int n;
        static char[,] q = new char[N, N];
        static bool[] col = new bool[N], dg = new bool[2 * N], ndg = new bool[2 * N];
        const int N = 10;

        static void Main()
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    q[i, j] = '.';
                }
            }

            Dfs(0);
        }

        static void Dfs(int u)
        {
            if (u == n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(q[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!col[i] && !dg[u + i] && !ndg[i - u + n])
                {
                    q[u, i] = 'Q';
                    col[i] = dg[u + i] = ndg[i - u + n] = true;
                    Dfs(u + 1);
                    col[i] = dg[u + i] = ndg[i - u + n] = false;
                    q[u, i] = '.';
                }
            }
        }
    }
}
