using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
     class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine( "Please Enter Your Age  For Driveing Lisence :" );
            int age = Convert.ToInt32( Console.ReadLine() );
            if (age<17 )
            {
                Console.WriteLine(" Your not eligible for Driveing :");

            }
            else if (age>=15 || age<=17)
            {
                Console.WriteLine(" You Will Eligible Soon  ");
            }
            else if ( age >= 18)
            {
                Console.WriteLine("Hurrey You Are Eligible ");
            }
            else {
                Console.WriteLine( "Sorry you are too Small");
                    
                    }


        }
    }
}
