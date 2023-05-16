using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_program_useing_if_else
{
    internal class Program

    {
       
        static void Main(string[] args)
        {
            int num, rem;
            Console.WriteLine( "please enter an Integer Value ");
            num=Convert.ToInt32(Console.ReadLine());
            rem = num % 2;

            if ( rem%2==0)
            {
                Console.WriteLine(" The number is even",num);
            }
            else
            {
                Console.WriteLine("the number is odd",num);
            }
            Console.ReadKey();
        }
    }
}
