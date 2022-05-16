namespace _154_滑动窗口
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            const int N = 1000010;
            int[] a = new int[N];
            int[] queue = new int[N];
            int head = 0, tail = -1;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (i - k + 1 > queue[head]) head++;
                while (head <= tail && a[queue[tail]] >= a[i]) tail--;
                queue[++tail] = i;
                if (i >= k - 1) Console.Write(a[queue[head]] + " ");
            }

            Console.WriteLine();

            head = 0; tail = -1;

            for (int i = 0; i < n; i++)
            {
                if (i - k + 1 > queue[head]) head++;
                while (head <= tail && a[queue[tail]] <= a[i]) tail--;
                queue[++tail] = i;
                if (i >= k - 1) Console.Write(a[queue[head]] + " ");
            }
        }
    }
}
