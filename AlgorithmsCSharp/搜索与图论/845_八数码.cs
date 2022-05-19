namespace _845_八数码
{
    class Program
    {
        static int[,] dirs = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

        static void Main()
        {
            string start = Console.ReadLine();
            Console.WriteLine(Bfs(start));
        }

        static int Bfs(string start)
        {
            return -1;
        }

        static void Swap<T>(T[] array, int a, int b)
        {
            T temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
