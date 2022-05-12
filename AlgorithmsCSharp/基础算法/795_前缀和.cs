namespace _795_前缀和
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] q = new int[n + 1];
            int[] s = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                q[i] = Convert.ToInt32(Console.ReadLine());
                s[i] = s[i - 1] + q[i];
            }

            while(m-- > 0)
            {
                int l = Convert.ToInt32(Console.ReadLine());
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s[r] - s[l - 1]);
            }
        }
    }
}
