using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ReverseOfWord
    {
        static void Main(string[] args)
        {
            string rev = "";
            Console.WriteLine("enter any word");
            string str = Console.ReadLine();
            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach(var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                rev = rev + temp + "";
            }
            Console.WriteLine("reverse of" + " " + str + "is:"+" "+rev);
            Console.ReadKey();

        }
    }
}
