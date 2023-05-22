class Program
{
    static int SumNumbers(int m, int n)
    {
        if (n == m)
        {
            return n;
        }
        else
        {
            return SumNumbers(m, n - 1) + n;
        }
    }

    static void Main(string[] args)
    {
        int m1 = 1, n1 = 15;
        Console.WriteLine("Sum of numbers from {0} to {1}: {2}", m1, n1, SumNumbers(m1, n1));

        int m2 = 4, n2 = 8;
        Console.WriteLine("Sum of numbers from {0} to {1}: {2}", m2, n2, SumNumbers(m2, n2));

        Console.ReadKey();
    }
}