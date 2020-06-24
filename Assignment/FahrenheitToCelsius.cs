using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit");
            int f = Convert.ToInt32(Console.ReadLine());
            double c = (f - 32) / 1.8;
            Console.WriteLine("Temperature in celsius=" + c);
            Console.ReadKey();


        }
    }
}
