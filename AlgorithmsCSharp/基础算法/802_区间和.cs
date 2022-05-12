namespace _802_区间和
{
    class Program
    {
        static List<int> alls;
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[300010];
            int[] s = new int[300010];
            List<(int, int)> add = new List<(int, int)>();
            List<(int, int)> query = new List<(int, int)>();
            alls = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                add.Add((x, c));
                alls.Add(x);
            }

            for (int i = 0; i < m; i++)
            {
                int l = Convert.ToInt32(Console.ReadLine());
                int r = Convert.ToInt32(Console.ReadLine());
                query.Add((l, r));
                alls.Add(l);
                alls.Add(r);
            }

            alls = alls.Distinct().ToList();
            alls.Sort();

            foreach (var item in add)
            {
                int x = Find(item.Item1);
                a[x] += item.Item2;
            }

            for (int i = 1; i <= alls.Count; i++)
            {
                s[i] = s[i - 1] + a[i];
            }

            foreach (var item in query)
            {
                int l = Find(item.Item1);
                int r = Find(item.Item2);
                Console.WriteLine(s[r] - s[l - 1]);
            }
        }

        private static int Find(int x)
        {
            int l = 0, r = alls.Count - 1;
            while (l < r)
            {
                int mid = (l + r) >> 1;
                if (alls[mid] >= x) r = mid;
                else l = mid + 1;
            }

            return r + 1;
        }
    }
}
