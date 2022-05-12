namespace _793_高精度乘法
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            List<int> A = new List<int>();
            for (int i = a.Length - 1; i >= 0; i--) A.Add(a[i] - '0');
            List<int> C = Mul(A, b);
            for (int j = C.Count - 1; j >= 0; j--) Console.Write(C[j]);
        }

        private static List<int> Mul(List<int> A, int b)
        {
            List<int> C = new List<int>();
            int t = 0;
            for (int i = 0; i < A.Count || t > 0; i++)
            {
                if (i < A.Count) t = A[i] * b + t;
                C.Add(t % 10);
                t /= 10;
            }

            while (C.Count > 1 && C.Last() == 0) C.RemoveAt(C.Count - 1);
            return C;
        }
    }
}
