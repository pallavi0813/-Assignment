using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0 ,n2 = 1;
            Console.Write(n1+" "+n2);
            for(int i=2;i<=40;i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
             
            }
            Console.ReadKey();
            

        }
       

    }
}
