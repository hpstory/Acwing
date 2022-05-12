namespace _785_QuickSort
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] q = new int[n];
            for (int i = 0; i < n; i++)
            {
                q[i] = Convert.ToInt32(Console.ReadLine());
            }

            QuickSort(q, 0, n - 1);

            foreach (int item in q)
            {
                Console.Write($"{item} ");
            }
        }

        private static void QuickSort(int[] q, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int i = left - 1;
            int j = right + 1;
            int pivot = q[new Random().Next(i, j)];
            while (i < j)
            {
                do i++; while (q[i] < pivot);
                do j--; while (q[j] > pivot);
                if(i < j)
                {
                    int temp = q[i];
                    q[i] = q[j];
                    q[j] = temp;
                }
            }

            QuickSort(q, left, j);
            QuickSort(q, j + 1, right);
        }
    }
}
