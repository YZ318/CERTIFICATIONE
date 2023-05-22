class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        int m1 = 2, n1 = 3;
        Console.WriteLine("A({0}, {1}) = {2}", m1, n1, Ackermann(m1, n1));

        int m2 = 3, n2 = 2;
        Console.WriteLine("A({0}, {1}) = {2}", m2, n2, Ackermann(m2, n2));

        Console.ReadKey();
    }
}
