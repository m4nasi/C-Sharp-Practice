using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what fahrenheit you want to convert");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double farhenheit = celcius * 9 / 5 + 32;
            Console.WriteLine(celcius + " in celcius is " + farhenheit);
            Console.ReadLine();

            Console.WriteLine("What kilograms do you want to convert?");
            double kilogram = Convert.ToDouble(Console.ReadLine());
            double pound = kilogram * 2.205;
            Console.WriteLine(kilogram +" in pounds is " + pound);
            Console.ReadLine();
        }   
    }
}
