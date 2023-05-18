using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_loops_Program_for_Printing_Paterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The No . Of  Rows You Want IN Pattern :");
           int row =int.Parse( Console.ReadLine() );
            Console.WriteLine("Please Enter The No . Of Columns You Want IN Pattern ");
            int columns = int.Parse( Console.ReadLine() );
            Console.WriteLine(" Enter the Symbol Wants To Insert ( ) ");
            String symbol = Console.ReadLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine( );
             }

        }
    }
}
