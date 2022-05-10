namespace _792_高精度减法
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
            List<int> C = new List<int>();
            if (Compare(A, B))
            {
                C = Sub(A, B);
            }
            else
            {
                C = Sub(B, A);
                Console.Write("-");
            }

            for (int k = C.Count - 1; k >= 0; k--) Console.Write(C[k]);
        }

        private static bool Compare(List<int> A, List<int> B)
        {
            if (A.Count != B.Count) return A.Count > B.Count;
            for (int i = A.Count - 1; i >= 0; i--)
            {
                if (A[i] != B[i]) return A[i] > B[i];
            }

            return true;
        }

        private static List<int> Sub(List<int> A, List<int> B)
        {
            List<int> C = new List<int>();
            int t = 0;
            for (int i = 0; i < A.Count; i++)
            {
                t = A[i] - t;
                if (i < B.Count) t -= B[i];
                C.Add((t + 10) % 10);
                t = t < 0 ? 1 : 0;
            }

            while (C.Count > 1 && C.Last() == 0) C.RemoveAt(C.Count - 1);
            return C;
        }
    }
}
