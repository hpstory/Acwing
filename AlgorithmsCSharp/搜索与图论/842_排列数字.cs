namespace _842_排列数字
{
    class Program
    {
        static int n;

        static int[] path;

        static bool[] st;

        static void Main()
        {
            n = Convert.ToInt32(Console.ReadLine());
            path = new int[10];
            st = new bool[10];
            DFS(0);
        }

        static void DFS(int u)
        {
            if (u == n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(path[i] + " ");
                }

                Console.WriteLine();

                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!st[i])
                {
                    path[u] = i;
                    st[i] = true;
                    DFS(u + 1);
                    st[i] = false;
                }
            }
        }
    }
}
