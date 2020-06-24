using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Palindrome
    {
        static void Main(String[] args)
        {
            string rev = "";
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            for(int i=str.Length-1;i>=0;i--)
            {
                rev += str[i].ToString();
            }
            if (rev == str)
            {
                Console.WriteLine(str + " " + "is palindrome");
            }
            else
                Console.WriteLine(str + " " + "is not palindrome");
            Console.ReadKey();
        }
    }
}
