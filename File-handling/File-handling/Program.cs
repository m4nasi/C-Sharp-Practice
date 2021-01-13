using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canContinue = true;

            while (canContinue)
            {
                Console.Clear();
                Console.WriteLine("Do you want to read or write to a file or quit?");
                string userResponse = Console.ReadLine();
                if(userResponse.ToLower() == "read")
                {
                    ReadFile();
                }
                else if(userResponse.ToLower() == "write")
                {
                    WriteFile();
                }
                else if(userResponse.ToLower() == "quit")
                {
                    canContinue = false;
                }
                else
                {
                    Console.WriteLine("Sorry I don't understand " + userResponse);
                }
            }
        }

        private static void WriteFile()
        {
            Console.Clear();
            Console.WriteLine("Please enter the file to write to");
            string fileName = Console.ReadLine();

            List<string> fileData = new List<string>();
            bool canContinue = true;
            while (canContinue)
            {
                Console.WriteLine("Enter the next line to save to the file or quit");
                string userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "quit")
                {
                    canContinue = false;
                }

                else
                {
                    fileData.Append(userResponse);
                }
            }

            File.WriteAllLines(fileName, fileData.ToArray());
        }

        private static void ReadFile()
        {
            Console.Clear();
            Console.WriteLine("Please enter the file to read from");
            string fileName = Console.ReadLine();

            string[] fileLines = File.ReadAllLines(fileName);

            foreach (string line in fileLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
