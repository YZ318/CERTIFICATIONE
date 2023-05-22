class Program
{
    static void PrintNumbers(int n)
    {
        if (n > 0)
        {
            Console.WriteLine(n);
            PrintNumbers(n - 1);
        }
    }

    static void Main(string[] args)
    {
        int n1 = 5;
        Console.WriteLine("Numbers from {0} to 1:", n1);
        PrintNumbers(n1);

        int n2 = 8;
        Console.WriteLine("Numbers from {0} to 1:", n2);
        PrintNumbers(n2);

        Console.ReadKey();
    }
}
