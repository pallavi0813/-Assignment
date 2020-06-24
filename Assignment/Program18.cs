using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program18
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter 2 words");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (string.Equals(str1, str2))
            {
                Console.WriteLine(str1 + " " + "and" + " " + str2 + " " + "are same");
            }
            else
                Console.WriteLine("They are different words");
            Console.ReadKey();
        }
    }
}
