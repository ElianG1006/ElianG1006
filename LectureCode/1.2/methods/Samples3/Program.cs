using System;

namespace Samples3
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Because I'm Batman.";
            bool isInString = WhereIsBatman(msg, out int indexOfBatman);
            Console.WriteLine($"Batman is in the string? {isInString}. Index: {indexOfBatman}");
        }

        private static bool WhereIsBatman(string message, out int index)
        {
            index = message.IndexOf("Batman");
            return index != -1;// != -1, returns true
        }
    }
}
