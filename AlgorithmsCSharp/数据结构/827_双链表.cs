namespace _827_双链表
{
    class Program
    {
        const int N = 100010;

        private static int index;

        private static int[] e;

        private static int[] l;

        private static int[] r;

        static void Main()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            Init();
            while (m-- > 0)
            {
                string s = Console.ReadLine();
                if (s == "D")
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    Remove(k + 1);
                }
                else if (s == "L")
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    Insert(0, x);
                }
                else if (s == "R")
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    Insert(l[1], x);
                }
                else if (s == "IL")
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    int x = Convert.ToInt32(Console.ReadLine());
                    Insert(l[k + 1], x);
                }
                else if (s == "IR")
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    int x = Convert.ToInt32(Console.ReadLine());
                    Insert(k + 1, x);
                }
            }

            for (int i = r[0]; i != 1; i = r[i])
            {
                Console.Write(e[i] + " ");
            }
        }

        static void Init()
        {
            e = new int[N];
            l = new int[N];
            r = new int[N];
            r[0] = 1;
            l[1] = 0;
            index = 2;
        }

        static void Insert(int k, int x)
        {
            // k右边插入一个数
            e[index] = x;
            r[index] = r[k];
            l[index] = k;
            l[r[k]] = index;
            r[k] = index;
            index++;
        }

        static void Remove(int k)
        {
            r[l[k]] = r[k];
            l[r[k]] = l[k];
        }
    }
}
