namespace _830_单调栈
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int top = 0;
            int[] stack = new int[100010];
            string result = string.Empty;
            while (n-- > 0)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                while (top > 0 && stack[top] >= x) top--;
                if (top > 0)
                {
                    result += stack[top] + " ";
                }
                else
                {
                    result += "-1 ";
                }

                stack[++top] = x;
            }

            Console.WriteLine(result);
        }
    }
}
