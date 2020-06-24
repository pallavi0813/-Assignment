using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
            Console.ReadKey();

        }
    }
}
