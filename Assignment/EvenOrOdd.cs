using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numbers:");
            int a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine(a+" "+"is an even number");
            }
            else
                Console.WriteLine(a+" "+ "is an odd number");
                Console.ReadKey();
        }
    }
}
