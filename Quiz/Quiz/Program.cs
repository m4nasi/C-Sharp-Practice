using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static int score = 0;
        static void AskQuestion(string question, string answer)
        {
            int attempts = 3;
            string response1;

            do
            {
                Console.WriteLine(question);
                response1 = Console.ReadLine();

                if (response1.ToLower() == answer) 
                {
                    Console.WriteLine("Well done!");
                    score += attempts;
                }

                else
                {
                    Console.WriteLine("Sorry " + response1 + " is incorrect");
                    if (--attempts != 0)
                    {
                        Console.WriteLine("you have " + attempts + " attempts remaining");
                    }
                }

            } while (attempts > 0 && response1.ToLower() != answer.ToLower());
        }
        static void Main(string[] args)
        {
            AskQuestion("What is the capital of England?", "london");
            AskQuestion("What is the capital of India?", "new delhi");
            AskQuestion("What is the capital of Spain?", "madrid");
            AskQuestion("What is the capital of France?", "paris");
            AskQuestion("What is the capital of Japan?", "tokyo");

            Console.WriteLine("The quiz is over, you scored " + score + " points");
            Console.ReadLine();
        }
    }
}
