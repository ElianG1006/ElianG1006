using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRandomNumbers();
            double returnedDouble = Multiplier(10, 3);
            //$ - C# interpolated strings
            Console.WriteLine($"10 * 3 = {returnedDouble}");
        }

        //a method that does not return anything
        private static void PrintRandomNumbers()
        {
            Random random = new Random();
            int randomNumber = random.Next();
            double randomDouble = random.NextDouble();
            Console.WriteLine(randomNumber);
            Console.WriteLine(randomDouble);
        }

        //a method that returns a double multiplied by a factor
        private static double Multiplier(double number, double factor)
        {
            double result = number * factor;
            return result;
        }
    }
}
