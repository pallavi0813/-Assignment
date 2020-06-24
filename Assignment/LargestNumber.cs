using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine(a + " " + "is the largest number");
            else if (b > a && b > c)
                Console.WriteLine(b + " " + "is the largest number");
            else
                Console.WriteLine(c + " " + "is the largest number");
            Console.ReadKey();
        }
    }
}
