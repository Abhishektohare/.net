using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_find_Factorial_of_number
{
    class Demo
    {
        public void Factor(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Factor " + i);

                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            Demo obj = new Demo();
            obj.Factor(n);
        }
    }
}
