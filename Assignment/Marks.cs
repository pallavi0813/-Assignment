using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Marks
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            int total = 0;
            Console.WriteLine("enter marks of 10 subjects");
            for(int i=0;i<10;i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<10;i++)
            {
                total = total + marks[i];
            }
            Console.WriteLine("total marks=" + total);
            int average = total / 10;
            Console.WriteLine("Average=" + average);
            Array.Sort(marks);
            Console.WriteLine("smallest number=" + marks[0]);
            Console.WriteLine("Largest number=" + marks[9]);
            Console.WriteLine("Ascending order");
            for (int i=0;i<10;i++)
            {
                Console.WriteLine(+marks[i]);
            }
            Array.Reverse(marks);
            Console.WriteLine("Descending order");
            for (int i=0;i<10;i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.ReadKey();
            


        }
        

    }
}
