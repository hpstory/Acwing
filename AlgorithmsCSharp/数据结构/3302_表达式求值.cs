namespace _3302_表达式求值
{
    class Program
    {
        static Stack<int> num;

        static Stack<char> op;

        static void Main()
        {
            string s = Console.ReadLine();
            num = new Stack<int>();
            op = new Stack<char>();
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { '+', 1 },
                { '-', 1 },
                { '*', 2 },
                { '/', 2 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int j = i, x = 0;
                    while (j < s.Length && char.IsDigit(s[j]))
                    {
                        x = x * 10 + s[j] - '0';
                        j++;
                    }

                    num.Push(x);
                    i = j - 1;
                }
                else if (s[i] == '(')
                {
                    op.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    while (op.Peek() != '(')
                    {
                        Eval();
                    }

                    op.Pop();
                }
                else
                {
                    while (op.Count > 0 && op.Peek() != '(' && map[op.Peek()] >= map[s[i]])
                    {
                        Eval();
                    }

                    op.Push(s[i]);
                }
            }

            while (op.Count > 0) Eval();
            Console.WriteLine(num.Peek());
        }

        private static void Eval()
        {
            int a = num.Pop();
            int b = num.Pop();
            char p = op.Pop();
            int result = 0;
            if (p == '+')
            {
                result = b + a;
            }
            else if (p == '-')
            {
                result = b - a;
            }
            else if (p == '*')
            {
                result = b * a;
            }
            else
            {
                result = b / a;
            }

            num.Push(result);
        }
    }
}
