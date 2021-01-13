using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_timetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string[,] timetable = { { "Form", "English", "Maths", "Geography", "Physics", "German" },
                { "English", "Maths", "Biology", "Computer Science", "PE", "Chemistry"},
                { "Form", "Ethics", "Maths", "English", "Physics", "Computer Science" } ,
                { "Chemistry", "English", "Maths", "Computer Science", "Physics", "Chemistry" },
                { "Form", "English", "Maths", "Geography", "Physics", "German" }
            };

            bool canContinue = true;
            while (canContinue)
            {
                Console.Clear();
                Console.WriteLine("+----------++----------++----------++----------++----------++----------++----------+");
                for (int dayCount = 0; dayCount < 5; dayCount++)
                {
                    string dayLine = days[dayCount] + ": ";
                    for (int lessonCount = 0; lessonCount < 6; lessonCount++)
                    {
                        dayLine += timetable[dayCount, lessonCount] + ", ";
                    }

                    Console.WriteLine(dayLine);
                    Console.WriteLine("+----------++----------++----------++----------++----------++----------++----------+");
                }
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Would you like to change a lesson?");
                string userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("What day do you want to change? (1- Monday , 5 - Friday)");
                    int dayindex = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine("What period do you want to change?");
                    int periodindex = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.WriteLine("This lesson is currently " + timetable[dayindex, periodindex] + " what do you want to change?");
                    string newLesson = Console.ReadLine();
                    timetable[dayindex, periodindex] = newLesson;
                }
                else
                {
                    canContinue = false;
                }
            }
        }
    }
}