namespace _791_高精度加法
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            for (int i = a.Length - 1; i >= 0; i--) A.Add(a[i] - '0');
            for (int j = b.Length - 1; j >= 0; j--) B.Add(b[j] - '0');
            List<int> C = Add(A, B);
            for (int k = C.Count - 1; k >= 0; k--) Console.Write(C[k]);
        }

        private static List<int> Add(List<int> A, List<int> B)
        {
            List<int> C = new List<int>();
            int t = 0;
            for (int i = 0; i < A.Count || i < B.Count; i++)
            {
                if (i < A.Count) t += A[i];
                if (i < B.Count) t += B[i];
                C.Add(t % 10);
                t /= 10;
            }

            if (t > 0) C.Add(1);
            return C;
        }
    }
}
