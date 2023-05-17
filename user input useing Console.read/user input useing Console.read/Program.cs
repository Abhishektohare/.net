using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input_useing_Console.read
{
    
  class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name :");
         String Firstname=Console.ReadLine();
            Console.WriteLine("Enter last name :");
            String Lastname=Console.ReadLine();
            
            Console.WriteLine( "Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Firstname )  +  (Lastname)  + "Your age is :"+ age);
            
            
            Console.ReadLine();

            
        }
    }
}
