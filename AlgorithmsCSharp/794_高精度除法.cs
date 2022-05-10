namespace _794_高精度除法
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            List<int> A = new List<int>();
            for (int i = a.Length - 1; i >= 0; i--) A.Add(a[i] - '0');
            int r = 0;
            List<int> C = Div(A, b, ref r);
            for (int j = C.Count - 1; j >= 0; j--) Console.Write(C[j]);
            Console.WriteLine("\n" + r);
        }

        private static List<int> Div(List<int> A, int b, ref int r)
        {
            List<int> C = new List<int>();
            r = 0;
            for (int i = A.Count - 1; i >= 0; i--)
            {
                r = r * 10 + A[i];
                C.Add(r / b);
                r %= b;
            }

            C.Reverse();
            while (C.Count > 1 && C.Last() == 0) C.RemoveAt(C.Count - 1);
            return C;
        }
    }
}
