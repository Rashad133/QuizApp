using System.Collections.Generic;

namespace QuizConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("[1] Create new quiz");
            Console.WriteLine("[2] Solve a quiz");
            Console.WriteLine("[3] Show quizzes");
            Console.WriteLine("[0] Quit");

            Console.WriteLine("=======================");
            Console.WriteLine("Hello quiz world");
            Console.WriteLine("=======================");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Sual adini daxil et");
                    string name = Console.ReadLine();
                    Console.WriteLine(name);
                    Console.WriteLine("Sual daxil et");
                    List<string> question = new List<string>();
                    Console.WriteLine(question);
                    break;
                case "2":
                    Console.WriteLine("Nece sual elave etmek isteyirsen?");
                    List
                    break;
                case "3":
                    Console.WriteLine("Sual daxil et:");
                    
                    break;
                case "4":
                    Console.WriteLine();
                    break;
            }


        }
    }
}