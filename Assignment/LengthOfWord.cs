using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class LengthOfWord
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter any word");
            string str = Console.ReadLine();
            Console.WriteLine("Length of" + " " + str + "=" + str.Length);
            Console.ReadKey();
        }
    }
}
