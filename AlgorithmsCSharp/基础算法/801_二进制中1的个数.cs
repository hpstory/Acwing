namespace _801_二进制中1的个数
{
    class Program
    {
        //static void Main()
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string res = string.Empty;
        //    for (int i = 0; i < n; i++)
        //    {
        //        int x = Convert.ToInt32(Console.ReadLine());
        //        int result = 0;
        //        while (x > 0)
        //        {
        //            x -= Lowbit(x);
        //            result++;
        //        }

        //        res = $"{res}{result} ";
        //    }

        //    Console.WriteLine(res);
        //}

        //private static int Lowbit(int x)
        //{
        //    return x & -x;
        //}

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                res = $"{res}{GetOneNumber(x)} ";
            }

            Console.WriteLine(res);
        }

        private static int GetOneNumber(int x)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                int bit = x >> i & 1;
                if (bit == 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
