using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TempClass
    {
     public TempClass () {
            Console.Write("Enter first number: ");
            int temp1 = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter second number: ");
            int temp2 = Convert.ToInt32(Console.ReadLine());
            if (temp1 == temp2)
            {
                Console.WriteLine("The numbers are thre same");
            }
            else if (temp1 > temp2) {
                Console.WriteLine( "The first number is bigger");
            }
            else {
                Console.WriteLine("The second number is bigger");
            }
        }
    }
}
