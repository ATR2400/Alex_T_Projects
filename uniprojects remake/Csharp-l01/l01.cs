using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_a01
{
    public class tests
    {
        public static void t01()
        {
            Console.Write("What is your favourite food?: ");
            string food=Console.ReadLine();

            Console.WriteLine("What is your favourite TV show?: ");
            string show = Console.ReadLine();

            Console.WriteLine($"I like to eat {food} while watching {show}");
        }

        public static void t02()
        {
            Console.Write("Enter length in inches: ");
            

            double inches = double.Parse(Console.ReadLine());
            double meters = inches * 0.0254;

            Console.WriteLine($"Length in m: {meters}");

            
        }

        public static void t03()
        {
            Console.Write("Cost of pizza slice $: ");
            double cost = double.Parse(Console.ReadLine());
            Console.Write("Number of slices: ");
            int slices = int.Parse(Console.ReadLine());



            Console.WriteLine($"Total cost of pizza slices: {cost * slices}");
        }

        public static void t04()
        {
            Console.Write("Enter principal amount $: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Enter interest %: ");
            double interest= double.Parse(Console.ReadLine())/100;

            Console.Write("Enter years: ");
            double years = double.Parse(Console.ReadLine());

            Console.Write("Enter number of times compounded: ");
            double compounded = double.Parse(Console.ReadLine());

            double balance = principal * (Math.Pow((1 + interest / compounded), years * compounded));

            Console.WriteLine($"Final balance: {balance}");


        }
    }
}