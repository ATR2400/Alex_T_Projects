using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_a03
{
    internal class tests
    {
        public static string t01(int day_number)
        {
            string day="";
            if (day_number == 1)
            {
                day="monday";
            }
            else if (day_number == 2)
            {
                day="Tuesday";
            }
            else if (day_number == 3)
            {
                day="Wednesday";
            }
            else if (day_number == 4)
            {
                day="Thursday";
            }
            else if (day_number == 5)
            {
                day="Friday";
            }
            else if (day_number == 6)
            {
                day="Saturday";
            }
            else if (day_number == 7)
            {
                day="Sunday";
            }
            else
            {
                day="\"What do you mean it's not a real day? I'll MAKE it real!\" - Antonie Bernier";
            }

            return day;
        }

        public static string t02(int aqi)
        {
            string pollution="";
            if (aqi >= 300)
            {
                pollution="Hazardous";
            }
            else if (aqi >= 201)
            {
                pollution="Very unhealthy";
            }
            else if (aqi >= 151)
            {
                pollution="Unhealthy";
            }
            else if (aqi >= 101)
            {
                pollution="Unhealthy for sensitive groups";
            }
            else if (aqi >= 51)
            {
                pollution="Moderate";
            }
            else
            {
                pollution="Good";
            }

            return pollution;
        }

        public static float t03(float v1, float v2, float v3)
        {
        float product;
        if (v1 >= v2 && v1 >= v3)
        {
            if (v2 >= v3)
            {
                product = v1 * v2;
            }
            else
            {
                product = v1 * v3;
            }
        }
        else if (v2 >= v1 && v2 >= v3)
        {
            if (v1 >= v3)
            {
                product = v2 * v1;
            }
            else
            {
                product = v2 * v3;
            }
        }
        else
        {
            if (v1 >= v2)
            {
                product = v3 * v1;
            }
            else
            {
                product = v3 * v2;
            }
        }
        return product;
        }

        // t04
        public static string t04(string rgb1, string rgb2)
        {
            string colour = "";

            if (rgb1 == "red")
            {
                if (rgb2 == "blue")
                    colour = "fuchsia";
                else if (rgb2 == "green")
                    colour = "yellow";
                else if (rgb2 == "red")
                    colour = "red";
                else
                    colour = "Error";
            }
            else if (rgb1 == "green")
            {
                if (rgb2 == "red")
                    colour = "yellow";
                else if (rgb2 == "blue")
                    colour = "aqua";
                else if (rgb2 == "green")
                    colour = "green";
                else
                    colour = "Error";
            }
            else if (rgb1 == "blue")
            {
                if (rgb2 == "red")
                    colour = "fuchsia";
                else if (rgb2 == "green")
                    colour = "aqua";
                else if (rgb2 == "blue")
                    colour = "blue";
                else
                    colour = "Error";
            }
            else
                colour = "Error";

            return colour;
        }


        // t05
        public static string t05(int number)
        {
            string yeeha = "";

            if (number % 3 == 0)
            {
                if (number % 7 == 0)
                    yeeha = "Yee Ha";
                else
                    yeeha = "Yee";
            }
            else if (number % 7 == 0)
            {
                if (number % 3 == 0)
                    yeeha = "Yee Ha";
                else
                    yeeha = "Ha";
            }
            else
                yeeha = "Nada";

            return yeeha;
        }
    }
}
