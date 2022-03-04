using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "15,43,96,12,5,100";
            string[] numberStrings = data.Split(',');
            for (int i = 0; i < numberStrings.Length; i++)
            {
                Console.WriteLine(numberStrings[i]);
            }


            string names = "Joker,Riddler,Catwoman,Twoface,Bane";
            Console.WriteLine("------------Villains----------");
            string[] villains = names.Split(',');
            for (int i = 0; i < villains.Length; i++)
            {
                Console.WriteLine(villains[i]);
            }

            Console.WriteLine("---------GRADES------------");
            string multiples = "15-43---96_Student1_Student2___Student5";
            char[] delimiters = new char[] { '-', '_' };
            string[] grades = multiples.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            Challenge2();
        }

        private static void Challenge2()
        {
            Console.Clear();
            string names = "Joker,,,Riddler,Catwoman,,Twoface,Bane|Gordon||Barbara";
            Console.WriteLine("------------DC Characters----------");
            char[] delimiters = new char[] { ',', '|' };
            string[] characters = names.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i]);
            }
        }
    }
}
