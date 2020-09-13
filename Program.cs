using System;
using System.Collections.Generic;
using System.Linq;

namespace yonch
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfQuestions = 10;

            var random = new Random();

            int correctAnswers = 0;

            for (int i = 0; i < numberOfQuestions; i++)
            {
                List<int> numbers = new List<int>
                {
                    random.Next(0, 20),
                    random.Next(0, 11)
                }.OrderByDescending(x => x).ToList();

                bool isPlus = random.Next(2) == 1;
                string sign = isPlus ? "+" : "-";

                Console.WriteLine($"{numbers[0]} {sign} {numbers[1]} = ?");
                int answer = int.Parse(Console.ReadLine());

                int expected = isPlus ? numbers.Sum() : numbers[0] - numbers[1];

                if (answer == expected)
                {
                    correctAnswers++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Right");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("The correct answer is : " + expected);
                    Console.ResetColor();

                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine(correctAnswers + " / " + numberOfQuestions);
            Console.WriteLine();
            Console.WriteLine("********************************");
            
        }
    }
}
