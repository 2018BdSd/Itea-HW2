using System;

namespace HW2
{
    class Program
    {
        static double Task1(int a, int b)
        {
            if (a > b)
                return a + b;
            else if (a == b)
                return a * b;
            else
                return a - b;
        }

        static string Task2(int x, int y)
        {
            if (x > 0 && y > 0)
                return "Quarte 1";
            else if (x < 0 && y > 0)
                return "Quarte 2";
            else if (x < 0 && y < 0)
                return "Quarte 3";
            else if (x > 0 && y < 0)
                return "Quarte 4";
            else
                return "lies on the axis";
        }

        static (int, int, int) Task3(int a, int b, int c)
        {
            if (a > b && a > c)
                return (a, Math.Max(b, c), Math.Min(b, c));
            else if (b > a && b > c)
                return (b, Math.Max(a, c), Math.Min(a, c));
            else
                return (c, Math.Max(a, b), Math.Min(a, b));
        }

        static string Task4(double a, double b, double c)
        {
            var d = b * b - 4 * a * c;
            var result = (Math.Round((-b + Math.Sqrt(d)) / 2 * a, 3), Math.Round((-b - Math.Sqrt(d)) / 2 * a, 3));

            if (d > 0)
                return $"x1={result.Item1} x2={result.Item2}";
            else if (d == 0)
                return $"x={result.Item1}";
            else
                return "d<0";
        }

        static string Task5(int number)
        {
            string[] Array1 = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] Array2 = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] Array3 = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int b = number % 10;
            int a = (number - b) / 10;

            if (number > 10 && number < 20) return Array2[number - 11];
            if (b == 0) return Array3[a - 1];

            return Array3[a - 1] + ' ' + Array1[b - 1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Task1(-2, 2));

            Console.WriteLine("\n" + Task2(1, -2));

            (int, int, int) result3 = Task3(-54, 7897, 3);
            Console.WriteLine("\n" + result3);

            Console.WriteLine("\n" + Task4(1, 6, 9));

            Console.WriteLine("\n" + Task5(67));
        }
    }
}
