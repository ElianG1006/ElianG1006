using System;

namespace Samples4
{
    class Program
    {
        static void Main(string[] args)
        {
            //in PostFix, number will be set to 99
            string postfixed = PostFix("Hello Spider-World", 99);
            Console.WriteLine(postfixed);

            //in PostFix, number will be set to 1
            postfixed = PostFix("Hello Spider-World");
            Console.WriteLine(postfixed);
        }

        private static string PostFix(string msg, int number = 1)
        {
            return $"{msg} #{number}";
        }
    }
}
