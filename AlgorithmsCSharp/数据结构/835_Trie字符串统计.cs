namespace _835_Trie字符串统计
{
    class Program
    {
        static int[,] son;

        static int[] count;

        static int index;

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            const int N = 100010;
            son = new int[N, 26];
            count = new int[N];
            index = 0;
            while (n-- > 0)
            {
                string[] s = Console.ReadLine().Split();
                if (s[0] == "I")
                {
                    Insert(s[1]);
                }
                else
                {
                    Console.WriteLine(Query(s[1]));
                }
            }
        }

        static void Insert(string s)
        {
            int p = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int u = s[i] - 'a';
                if (son[p,u] == 0) son[p, u] = ++index;
                p = son[p, u];
            }

            count[p]++;
        }

        static int Query(string s)
        {
            int p = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int u = s[i] - 'a';
                if (son[p, u] == 0) return 0;
                p = son[p, u];
            }

            return count[p];
        }
    }
}
