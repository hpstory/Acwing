namespace _790_数的三次方根
{
    class Program
    {
        static void Main()
        {
            double n = Convert.ToDouble(Console.ReadLine());
            double l = -10000, r = 10000;
            while (r - l > 1e-8)
            {
                double mid = (l + r) / 2;
                if (mid * mid * mid >= n)
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }

            Console.WriteLine(string.Format("{0:f6}", l));
        }
    }
}
