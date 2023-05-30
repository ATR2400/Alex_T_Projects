internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Would you like to test t01?: ");
        string progress = Console.ReadLine();

        if (progress.ToUpper() == "YES")
        {
            Csharp_a02.tests.t01();
        }

        Console.Write("Would you like to test t02?: ");
        progress = Console.ReadLine();

        if (progress.ToUpper() == "YES")
        {
            Csharp_a02.tests.t02();
        }

        Console.Write("Would you like to test t03?: ");
        progress = Console.ReadLine();

        if (progress.ToUpper() == "YES")
        {
            Csharp_a02.tests.t03();
        }

        Console.Write("Would you like to test t04?: ");
        progress = Console.ReadLine();

        if (progress.ToUpper() == "YES")
        {
            Csharp_a02.tests.t04();
        }

        Console.Write("Would you like to test t05?: ");
        progress = Console.ReadLine();

        if (progress.ToUpper() == "YES")
        {
            Csharp_a02.tests.t05();
        }
    }
}