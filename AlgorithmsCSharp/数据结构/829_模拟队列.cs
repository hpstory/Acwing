namespace _829_模拟队列
{
    class Program
    {
        static void Main()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[] queue = new int[100010];
            int head = 0, tail = -1;
            while (m-- > 0)
            {
                string op = Console.ReadLine();
                if (op == "push")
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    queue[++tail] = x;
                }
                else if (op == "pop")
                {
                    head++;
                }
                else if (op == "empty")
                {
                    if (tail >= head)
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                    
                }
                else if (op == "query")
                {
                    Console.WriteLine(queue[head]);
                }
            }
        }
    }
}
