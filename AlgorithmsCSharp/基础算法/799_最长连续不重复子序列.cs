namespace _799_最长连续不重复子序列
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] s = new int[100010];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = 0;
            for (int i = 0, j = 0; i < n; i++)
            {
                s[a[i]]++;
                while (s[a[i]] > 1)
                {
                    s[a[j]]--;
                    j++;
                }

                result = Math.Max(result, i - j + 1);
            }

            Console.WriteLine(result);
        }
    }
}
