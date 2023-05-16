using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_and_String_Conct
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( " Please Enter Your Name  ");
            // String Concatenation
            String name = Console.ReadLine();
            Console.WriteLine("Hey Hello " + name );
            Console.WriteLine("What's Your Age ?");
            // String Type casting
            string Age = Console.ReadLine();
           
            Console.WriteLine("Your Age after 4 years "  + (Convert.ToInt32(Age) + 4));
            
            Console.ReadLine();
        }
    }
}
