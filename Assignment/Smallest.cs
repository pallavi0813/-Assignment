using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Smallest
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 numbers");
            for(int i=0;i<5;i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(a);
            Console.WriteLine(a[0] + " " + "is the smallest number");
            Console.ReadKey();
        }
    }
}
