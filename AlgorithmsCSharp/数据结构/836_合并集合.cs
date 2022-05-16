namespace _836_合并集合
{
    class Program
    {
        static int[] p;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            p = new int[100010];
            for (int i = 0; i < n; i++)
            {
                p[i] = i;
            }

            while (m-- > 0)
            {
                string op = Console.ReadLine();
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (op == "M")
                {
                    p[Find(a)] = Find(b);
                }
                else
                {
                    if (Find(a) == Find(b)) Console.WriteLine("Yes");
                    else Console.WriteLine("No");
                }
            }
        }

        static int Find(int x)
        {
            if (p[x] != x) p[x] = Find(p[x]);
            return p[x];
        }
    }
}
