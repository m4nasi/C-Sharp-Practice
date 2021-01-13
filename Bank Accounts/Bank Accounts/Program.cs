using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts
{
    public class details
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string AccountNumber { get; set; }
        public string SortCode{ get; set; }

        public details (string name, string DoB, string AN, string SC)
        {
            Name = name;
            DateOfBirth = DoB;
            AccountNumber = AN;
            SortCode = SC;
        }
    }

    public class child : details
    {
        public string Overdraft { get; set; }
        public string ExpiryDate { get; set; }

        public child (string OD, string ED)
        {
            Overdraft = OD;
            ExpiryDate = ED;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name you have on the account?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the date of birth you have on the account? (**/**/****)");
            string DoB = Console.ReadLine();

            Console.WriteLine("What is the account number you have on the account?");
            string AN = Console.ReadLine();

            Console.WriteLine("What is the sort code you have on the account?");
            string SC = Console.ReadLine();

            details person1 = new details(name, DoB, AN, SC);
            Console.WriteLine("person1 Name = {0} Date of Birth = {1} Account Number = {2} Sort Code = {3}", person1.Name, person1.DateOfBirth, person1.AccountNumber, person1.SortCode);
            Console.ReadLine();
        }
    }
}
