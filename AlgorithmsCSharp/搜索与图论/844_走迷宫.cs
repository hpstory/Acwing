namespace _844_走迷宫
{
    class Program
    {
   
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Queue<(int, int)> queue = new Queue<(int, int)>();
            int[,] dirs = { { 0, 1 }, { 1, 0 }, { -1, 0 }, { 0, -1 } };
            int[,] graph = new int[110, 110];
            int[,] distance = new int[110, 110];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    graph[i, j] = Convert.ToInt32(Console.ReadLine());
                    distance[i, j] = -1;
                }
            }

            distance[0, 0] = 0;
            queue.Enqueue((0, 0));
            while (queue.Count > 0)
            {
                var x = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int r = x.Item1 + dirs[i, 0];
                    int c = x.Item2 + dirs[i, 1];
                    if (r >= 0 && r < n && c >= 0 && c < m && graph[r, c] == 0 && distance[r, c] == -1)
                    {
                        distance[r, c] = distance[x.Item1, x.Item2] + 1;
                        queue.Enqueue((r, c));
                    }
                }
            }

            Console.WriteLine(distance[n - 1, m - 1]);
        }
    }
}
