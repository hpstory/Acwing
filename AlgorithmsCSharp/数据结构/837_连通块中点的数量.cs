namespace _837_连通块中点的数量
{
    class Program
    {
        static int[] q;
        static int[] count;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            const int N = 100010;
            q = new int[N];
            count = new int[N];
            for (int i = 0; i < n; i++)
            {
                q[i] = i;
                count[i] = 1;
            }

            while (m-- > 0)
            {
                string op = Console.ReadLine();
                if (op == "C")
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (Find(a) == Find(b)) continue;
                    count[Find(b)] += count[Find(a)];
                    q[Find(a)] = Find(b);
                }
                else if (op == "Q1")
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (Find(a) == Find(b)) Console.WriteLine("Yes");
                    else Console.WriteLine("No");
                }
                else
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(count[Find(a)]);
                }
            }
        }

        static int Find(int x)
        {
            if (q[x] != x) q[x] = Find(q[x]);
            return q[x];
        }
    }
}
