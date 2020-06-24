using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class SumOfCubes
    {
        static void Main(string[] args)
        {
            int sum = 5*5*5;
            Console.WriteLine("Enter an integer number:");
            int n = int.Parse(Console.ReadLine());
            for(int i=6;i<=n;i++)
            {
                sum =  sum+(i * i * i);

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
