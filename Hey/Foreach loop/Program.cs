using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hey
{
    class Program
    {
     
        static void Main(string[] args)
        {
            String[] cars = { " Tata", "Maruti", " Mahindra", "BMW" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //useing Foreach loop
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
            // use length function to get length off array
            Console.WriteLine(cars.Length);

            Console.ReadLine();
            
            

        }
    }
}
