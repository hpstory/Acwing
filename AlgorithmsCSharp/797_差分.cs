namespace _797_差分
{
    class Program
    {
        private static int[] b;
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 10];
            b = new int[n + 10];
            for (int i = 1; i <= n; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Insert(i, i, number);
            }

            while (m-- > 0)
            {
                int l = Convert.ToInt32(Console.ReadLine());
                int r = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                Insert(l, r, c);
            }

            for (int i = 1; i <= n; i++)
            {
                a[i] = a[i - 1] + b[i];
                //b[i] += b[i - 1];
                Console.Write(a[i] + " ");
            }
        }

        private static void Insert(int l, int r, int c)
        {
            b[l] += c;
            b[r + 1] -= c;
        }
    }
}
