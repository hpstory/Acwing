namespace _841_字符串哈希
{
    class Program
    {
        static ulong[] hash;

        static ulong[] pow;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            string s = " " + Console.ReadLine();
            int N = 100010;
            int P = 131;
            hash = new ulong[N];
            pow = new ulong[N];

            pow[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                pow[i] = pow[i - 1] * (ulong)P;
                hash[i] = hash[i - 1] * (ulong)P + s[i];
            }

            while (m-- > 0)
            {
                int l1 = Convert.ToInt32(Console.ReadLine());
                int r1 = Convert.ToInt32(Console.ReadLine());
                int l2 = Convert.ToInt32(Console.ReadLine());
                int r2 = Convert.ToInt32(Console.ReadLine());

                if (Find(l1, r1) == Find(l2, r2)) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
        }

        static ulong Find(int l, int r)
        {
            return hash[r] - hash[l - 1] * pow[r - l + 1];
        }
    }
}
