
namespace Csharp_a01
{

    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Run t01?: ");

            string proceed = Console.ReadLine();
            if (proceed.ToUpper()=="YES")
            { 
                tests.t01();
                Console.WriteLine("\n");
            }

            Console.Write("Run t02?: ");

            proceed = Console.ReadLine();
            if (proceed.ToUpper() == "YES")
            {
                tests.t02();
                Console.WriteLine("\n");
            }

            Console.Write("Run t03?: ");

            proceed = Console.ReadLine();
            if (proceed.ToUpper() == "YES")
            {
                tests.t03();
                Console.WriteLine("\n");
            }

            Console.Write("Run t04?: ");

            proceed = Console.ReadLine();
            if (proceed.ToUpper() == "YES")
            {
                tests.t04();
                Console.WriteLine("\n");
            }


        }
    }
}


