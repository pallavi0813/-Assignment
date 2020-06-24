using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for(int i=n;i>0;i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of" + " " + n + " " + "is" + " " + fact);
            Console.ReadKey();
        }
    }
}
