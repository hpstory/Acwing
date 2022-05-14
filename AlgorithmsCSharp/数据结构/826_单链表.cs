namespace _826_单链表
{
    class Program
    {
        private static int[] e;

        private static int[] ne;

        private static int head;

        private static int index;

        static void Main()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            Init();
            while (m-- > 0)
            {
                string s = Console.ReadLine();
                if (s == "H")
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    AddToHead(x);
                }
                else if (s == "D")
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    Remove(k - 1);
                }
                else
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    int x = Convert.ToInt32(Console.ReadLine());
                    Insert(k - 1, x);
                }
            }

            for (int i = head; i != -1; i = ne[i])
            {
                Console.Write(e[i] + " ");
            }
        }

        private static void Init()
        {
            head = -1;
            index = 0;
            e = new int[100010];
            ne = new int[100010];
        }

        private static void AddToHead(int x)
        {
            // 表示向链表头插入一个数x
            e[index] = x;
            ne[index] = head;
            head = index;
            index++;
        }

        private static void Insert(int k, int x)
        {
            // 表示在第k个插入的数后面插入一个数x
            e[index] = x;
            ne[index] = ne[k];
            ne[k] = index;
            index++;
        }

        private static void Remove(int k)
        {
            if (k == -1) head = ne[head];
            else ne[k] = ne[ne[k]];
        }
    }
}
