namespace _2816_判断子序列
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[m];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < m; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
            }

            int x = 0;
            for (int y = 0; x < n && y < m; y++)
            {
                if (a[x] == b[y]) x++;
            }

            if (x == n) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
