using Csharp_a03;



internal class Program
{
    private static void Main(string[] args)
    {
        int num = 9;
        string result=tests.t01(num);
        Console.WriteLine(result);
        

        string pollution = tests.t02(301);
        Console.WriteLine(pollution);

        float product= tests.t03(1,3,0);
        Console.WriteLine(product);

        string colour=tests.t04("red","blue");
        Console.WriteLine(colour);

        string yeehaw=tests.t05(6);
        Console.WriteLine(yeehaw);

        Console.ReadLine();
    }
}