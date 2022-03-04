using System;

namespace Samples2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 5;
            Console.Write(number);
            double multiplier = RandomFactor(ref number);
            Console.WriteLine($" * {multiplier} = {number}");
        }

        private static double RandomFactor(ref double num)//num is an alias (another name) for number
        {
            Random random = new Random();
            double factor = random.Next(100);
            num *= factor;
            return factor;
        }
    }
}
