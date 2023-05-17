using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("i value: {0}", i);
                //useing Increment ooperator
                i++;
                //Initial value j
                int j = 1;
                do
                {
                    Console.WriteLine("j value: {0}", j);
                    j++;
                } while (j < 2);
            } while (i < 4);
            Console.WriteLine("loop Ended");
            Console.ReadLine();

        }
    }
}
