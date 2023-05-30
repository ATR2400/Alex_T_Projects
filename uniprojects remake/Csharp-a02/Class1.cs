using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Csharp_a02
{
    internal class tests
    {
        public static void t01()
        {
            Console.Write("Enter the total sales: $");
            float total_sales = float.Parse(Console.ReadLine());
            string tax = (total_sales * (float)0.185).ToString("C");

            Console.WriteLine($@"Projected tax report
--------------------------
Total sales: {total_sales.ToString("C")}
Annual tax: %18.5
--------------------------
Tax: {tax}");
        }
        public static void t02()
        {
            Console.Write("Enter positive whole number: ");
            int num = int.Parse(Console.ReadLine());
            int backup_num = num;
            int total = 1;
           
            
            while (num > 0)
            {
                int digit = num % 10;
                total *= digit;
                num = num / 10;

            }
            Console.WriteLine($"The product of all numbers in {backup_num} is {total}");
        }

        public static void t03()
        {
            Console.Write("Enter a date in the format DDMMYYYY: ");
            int date = Convert.ToInt32(Console.ReadLine());
            int year = date % 10000;
            int DDMM = date / 10000;
            int month = DDMM % 100;
            int day = DDMM / 100;
            Console.WriteLine($"The reformatted date: {year}/{month:D2}/{day:D2}");
        }

        public static void t04()
        {
            Console.Write("Pieces of cake: ");
            int pieces = int.Parse(Console.ReadLine());
            Console.Write("Partgoers: ");
            int partygoers = int.Parse(Console.ReadLine());

            int recieved = pieces / partygoers;
            int remainder = pieces % partygoers;

            Console.WriteLine($@"Each partygoer recieves {recieved} pieces of cake
There will be {remainder} pieces remaining");
        }

        public static void t05()
        {
            Console.WriteLine("Enter foundation length (m): ");
            float foundationLength = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter foundation width (m): ");
            float foundationWidth = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter foundation height (m): ");
            float foundationHeight = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter wall height (m): ");
            float wallHeight = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter cost of concrete ($/m^3): ");
            float costOfConcrete = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter cost of bricks ($/m^2): ");
            float costOfBricks = float.Parse(Console.ReadLine());

            float volume = foundationWidth * foundationLength * foundationHeight;
            float foundation_cost = volume * costOfConcrete;
            float area = 2 * ((wallHeight * foundationLength) + (wallHeight * foundationWidth));
            float wall_cost = area * costOfBricks;

            Console.WriteLine($@"Concrete needed for foundation(m^3): {volume}
Cost of concrete: ${foundation_cost}
bricks needed for wall(m^2): {area}
Cost of wall: ${wall_cost}
Total cost: ${foundation_cost+wall_cost}");

          


        }
    } 
}
