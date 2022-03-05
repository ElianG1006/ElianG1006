using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayChallenge();

            ListChallenge();
        }

        private static void ListChallenge()
        {
           string num = Console.ReadLine();

            int Grades = Int32.Parse(num);
            
            List<double> grades = new List<double>(9);
            Random rando = new Random();
            for (int i = 0; i < Grades; i++)
            {
                grades.Add(rando.NextDouble() * 100);
            }
            PrintGrades(grades);
            int numberOfGradesRemoved = DropFailing(grades);
            Console.WriteLine($"{numberOfGradesRemoved} dropped.");
            PrintGrades(grades);

            List<double> curvedGrades = CurveGrades(grades);
            Console.WriteLine("----------Curved Grades----------");
            PrintGrades(curvedGrades);
        }

        private static List<double> CurveGrades(List<double> grades)
        {
            List<double> curved = grades.ToList();
            for (int i = 0; i < curved.Count; i++)
            {
                curved[i] += 5;
                if (curved[i] > 100) curved[i] = 100;
            }
            return curved;
        }

        private static int DropFailing(List<double> grades)
        {
            //loop over the list and remove all grades < 59.5
            Console.WriteLine("-------Drop Failing Grades----------");
            int numberRemoved = 0;
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    if(grades[i] < 59.5)
            //    {
            //        grades.RemoveAt(i);
            //        numberRemoved++;
            //        i--;//force the current index to be re-evaluated
            //    }
            //}
            //OR...use a reverse for loop
            for (int i = grades.Count - 1; i >= 0; i--)
            {
                if (grades[i] < 59.5)
                {
                    grades.RemoveAt(i);//shift all items after it
                    numberRemoved++;
                }
            }
            return numberRemoved;
        }

        private static void PrintGrades(List<double> grades)
        {
            Console.WriteLine("------------GRADES-----------");
            for (int i = 0; i < grades.Count; i++)
            {
                //ternary operator
                Console.ForegroundColor = (grades[i] > 89) ? ConsoleColor.Green :
                                          (grades[i] > 79) ? ConsoleColor.DarkCyan :
                                          (grades[i] > 69) ? ConsoleColor.Yellow :
                                          (grades[i] > 59) ? ConsoleColor.DarkYellow :
                                          ConsoleColor.Red;
                Console.WriteLine($"{grades[i],7:N2}");
            }
            Console.ResetColor();
        }

        private static void ArrayChallenge()
        {
            Random rando = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rando.Next();
            }
            Console.WriteLine("-------------ARRAY CHALLENGE-----------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
