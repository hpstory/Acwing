namespace _828_模拟栈
{
    class Program
    {
        static void Main()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[] stack = new int[100010];
            int top = 0;
            while (m-- > 0)
            {
                string op = Console.ReadLine();
                if (op == "push")
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    top++;
                    stack[top] = x;
                }
                else if (op == "query")
                {
                    Console.WriteLine(stack[top]);
                }
                else if (op == "pop")
                {
                    top--;
                }
                else if (op == "empty")
                {
                    Console.WriteLine(top > 0 ? "NO" : "YES");
                }
            }
        }
    }
}
