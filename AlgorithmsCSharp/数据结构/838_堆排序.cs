namespace _838_堆排序
{
    class Program
    {
        static int[] heap;

        static int count;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            heap = new int[100010];
            count = n;
            for (int i = 1; i <= n; i++)
            {
                heap[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = n / 2; i > 0; i--)
            {
                Down(i);
            }

            while (m-- > 0)
            {
                Console.Write(heap[1] + " ");
                heap[1] = heap[count--];
                Down(1);
            }
        }

        static void Down(int x)
        {
            int t = x;
            if (x * 2 <= count && heap[x * 2] < heap[t]) t = x * 2;
            if (x * 2 + 1 <= count && heap[x * 2 + 1] < heap[t]) t = x * 2 + 1;
            if (t != x)
            {
                int temp = heap[t];
                heap[t] = heap[x];
                heap[x] = temp;
                Down(t);
            }
        }
    }
}
