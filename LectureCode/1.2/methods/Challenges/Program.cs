using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintMessage();
         

            string msg = GetMessage();

            PrintMessage(msg);
            TimeStamp(ref msg);
            Console.WriteLine(msg);

            MyFavoriteNumber(out int myFave);
            Console.WriteLine($"My favorite number is {myFave}.");

        }

        private static void MyFavoriteNumber(out int favorite)
        {
            Console.Write("What is your favorite number? ");
            string fav = Console.ReadLine();
            bool isANumber = int.TryParse(fav, out favorite);
            if(isANumber != true)
                Console.WriteLine("Invalid number.");
        }

        private static void TimeStamp(ref string message)
        {
            message = $"{DateTime.Now} {message}";
        }

        private static string GetMessage()
        {
            Console.Write("Please enter a message: ");
            string message = Console.ReadLine();
            return message;
        }

        private static void PrintMessage(string messageToPrint = "Hello Gotham!")
        {
            Console.WriteLine(messageToPrint);
        }
        
        private static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham!");
        }
    }
}
