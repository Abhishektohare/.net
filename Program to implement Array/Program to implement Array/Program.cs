using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_implement_Array
{
     class Program
    {
        static void Main(string[] args)
        {
            // Creating Array
            string[] fruit = {"Apple","Chikoo","Grapes", "Banana" };
            Console.WriteLine(fruit[0]);
            Console.WriteLine(fruit[1]);
            // useing for loop for Display entire elements of array
            for(int i=0;i<fruit.Length;i++)
            {
                Console.WriteLine(fruit[i]);
            }
            Console.ReadLine();
        }
    }
}
