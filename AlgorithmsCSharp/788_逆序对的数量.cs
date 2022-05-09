namespace _788_逆序对的数量
{
    class Program
    {
        private static long count;

        private static int[] temp;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] q = new int[n];
            temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                q[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(MergeSort(q, 0, n - 1));
        }

        private static long MergeSort(int[] q, int l, int r)
        {
            if (l >= r)
            {
                return 0;
            }

            int mid = (l + r) >> 1;
            count = MergeSort(q, l, mid) + MergeSort(q, mid + 1, r);
            int k = 0, i = l, j = mid + 1;
            while (i <= mid && j <= r)
            {
                if (q[i] <= q[j]) temp[k++] = q[i++];
                else
                {
                    temp[k++] = q[j++];
                    count += mid - i + 1;
                }
            }

            while (i <= mid) temp[k++] = q[i++];
            while (j <= r) temp[k++] = q[j++];

            for (int a = l, b = 0; a <= r; a++, b++) q[a] = temp[b];
            return count;
        }
    }
}
