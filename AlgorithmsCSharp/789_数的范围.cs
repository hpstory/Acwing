namespace _789_数的范围
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < q; i++)
            {
                int l = 0, r = n - 1;
                int k = Convert.ToInt32(Console.ReadLine());
                while (l < r)
                {
                    int mid = (l + r)>> 1;
                    if (a[mid] < k) l = mid + 1;
                    else r = mid;
                }

                if (a[l] != k)
                {
                    Console.WriteLine("-1 -1");
                }
                else
                {
                    Console.Write($"{l}");
                    r = n - 1;
                    while (l < r)
                    {
                        int mid = (l + r + 1) >> 1;
                        if (a[mid] > k) r = mid - 1;
                        else l = mid;
                    }

                    Console.WriteLine($"{l}");
                }
            }
        }
    }
}
