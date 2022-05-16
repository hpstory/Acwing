namespace _143_最大异或对
{
    class Program
    {
        static int[,] son;

        static int index;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int N = 100010;
            son = new int[N, 2];
            index = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                Insert(a[i]);
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int t = Query(a[i]);
                result = Math.Max(result, a[i]^t);
            }

            Console.WriteLine(result);
        }

        static void Insert(int x)
        {
            int p = 0;
            for (int i = 30; i >=0; i--)
            {
                int u = x >> i & 1;
                if (son[p, u] == 0) son[p, u] = ++index;
                p = son[p, u];
            }
        }

        static int Query(int x)
        {
            int p = 0, result = 0;
            for (int i = 30; i >= 0; i--)
            {
                int u = x >> i & 1; 
                if (son[p, 1 - u] > 0)
                {
                    p = son[p, 1 - u];
                    result = result * 2 + 1 - u;
                }
                else
                {
                    p = son[p, u];
                    result = result * 2 + u;
                }
            }

            return result;
        }
    }
}
