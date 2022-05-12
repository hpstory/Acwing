namespace _800_数组元素的目标和
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
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

            for (int i = 0, j = m - 1; i < n; i++)
            {
                while (j >= 0 && a[i] + b[j] > x) j--;
                if (a[i] + b[j] == x)
                {
                    Console.WriteLine($"{i} {j}");
                    break;
                }
            }
        }
    }
}
