namespace _803_区间合并
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] segs = new int[n][];
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                int l = Convert.ToInt32(Console.ReadLine());
                int r = Convert.ToInt32(Console.ReadLine());
                segs[i] = new int[] { l, r };
            }

            Array.Sort(segs, (x, y) => {
                return x[0].CompareTo(y[0]);
            });

            int st = int.MinValue, ed = int.MinValue;

            foreach (int[] seg in segs)
            {
                if (ed < seg[0])
                {
                    if (st != int.MinValue)
                    {
                        result.Add(
                            new List<int> { st, ed });
                    }
                    st = seg[0];
                    ed = seg[1];
                }
                else
                {
                    ed = Math.Max(ed, seg[1]);
                }
            }

            result.Add(new List<int> { st, ed });

            Console.WriteLine(result.Count);
        }
    }
}
