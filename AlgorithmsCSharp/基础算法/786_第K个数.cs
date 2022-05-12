namespace _786_第K个数
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int[] q = new int[n];
            for (int i = 0; i < n; i++)
            {
                q[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = QuickSort(q, 0, n - 1, k);
            Console.WriteLine(result);
        }

        private static int QuickSort(int[] q, int l, int r, int k)
        {
            if (l == r) return q[l];

            int i = l - 1;
            int j = r + 1;
            int x = q[(l + r) >> 1];
            while (i < j)
            {
                do i++; while (q[i] < x);
                do j--; while (q[j] > x);
                if (i < j)
                {
                    int temp = q[i];
                    q[i] = q[j];
                    q[j] = temp;
                }
            }

            int sl = j - l + 1;
            if (k <= sl) return QuickSort(q, l, j, k);
            return QuickSort(q, j + 1, r, k - sl);
        }
    }
}
