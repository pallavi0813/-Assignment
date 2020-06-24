using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class TotalEvenOdd
    {
        static void Main(string[] args)
        {
            int countOfEven = 0;
            int countOfOdd = 0;
            Console.WriteLine("How many values you want to enter:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter" + " " + n + " " + "elements");
            int[] a = new int[n];
            for (int i=0;i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] % 2 == 0)
                {
                     countOfEven+= 1;
                }
                else
                     countOfOdd += 1;

            }
            Console.WriteLine("Total even numbers=" + countOfEven);
            Console.WriteLine("Total odd numbers=" + countOfOdd);
            Console.ReadKey();

        }
    }
}
