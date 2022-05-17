namespace _840_模拟散列表
{
    class Program
    {
        static int[] hash;

        const int none = 0x3f3f3f3f;

        const int N = 200003;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            hash = new int[N];
            Array.Fill(hash, none);
            while (n-- > 0)
            {
                string op = Console.ReadLine();
                int x = Convert.ToInt32(Console.ReadLine());
                int k = Find(x);
                if (op == "I")
                {
                    hash[k] = x;
                }
                else if (op == "Q")
                {
                    if (hash[k] != none) Console.WriteLine("Yes");
                    else Console.WriteLine("No");
                }
            }
        }

        static int Find(int x)
        {
            int k = (x % N + N) % N;
            while (hash[k] != none && hash[k] != x)
            {
                k++;
                if (k == N) k = 0;
            }

            return k;
        }
    }
}
