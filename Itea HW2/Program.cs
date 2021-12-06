using System;

namespace HW2
{
    class Program
    {
        static double Task1(int a, int b)
        {
            double result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else 
            {
                result = a - b;
            }

            return result;
        }

        static string Task2(int x, int y)
        {
            string n="lies on axis";

            if (x > 0 && y > 0)
            {
                n = "Quarte 1";
            }
            else if (x < 0 && y > 0)
            {
                n = "Quarte 2";
            }
            else if (x < 0 && y < 0)
            {
                n = "Quarte 2";
            }
            else if (x > 0 && y < 0)
            {
                n = "Quarte 4";
            }

            return n;
        }

        static void Task3(ref int a, ref int b, ref int c)
        {
            if (a < b)
            {
                (a, b) = (b, a);
            }
            if (a < c)
            {
                (a, c) = (c, a);
            }
            if (b < c)
            {
                (b, c) = (c, b);
            }
        }

        static (double,double) Task4(double a, double b, double c)
        {
            double X1;
            double X2;

            double d = b * b - 4 * a * c;

            if (d>=0)
            {
                X1 = Math.Round((-b + Math.Sqrt(d)) / 2 * a, 3);
                X2 = Math.Round((-b - Math.Sqrt(d)) / 2 * a, 3);
            }
            else
            {
                X1 = 0;
                X2 = 0;
            }

            return (X1, X2);
        }

        static string Task5(int number)
        {
            string result;

            string[] Array1 = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] Array2 = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] Array3 = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int b = number % 10;
            int a = number/ 10;

            if (number > 10 && number < 20)
            {
                result=Array2[number - 11];
            }
            else if (b == 0)
            {
                result=Array3[a - 1];
            }
            else
            {
                result = Array3[a - 1] + ' ' + Array1[b - 1];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Task1(-2, 2));

            Console.WriteLine("\n" + Task2(0, -2));

            int a = -1;
            int b = 43;
            int c = 100;
            
            Task3(ref a, ref b, ref c);
            Console.WriteLine("\n" + $"{a},{b},{c}");

<<<<<<< HEAD
            (double, double) result = Task4(5, 3, 7);
            Console.WriteLine("\n" + result);
  
            Console.WriteLine("\n" + Task5(11));
=======
            Console.WriteLine("\n" + Task5(67));
>>>>>>> a4df2607043b74d879595231d4a19f8dbfac3954
        }
    }
}
