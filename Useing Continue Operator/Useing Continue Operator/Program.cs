using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Useing_Continue_Operator
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas Enter No..." );
            // Here Instead of useing ConverTo. Method WE are useing Parse Method 
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum);
        }
    }
}
