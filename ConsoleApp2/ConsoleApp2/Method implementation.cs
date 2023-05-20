using System;
using System.Xml.Serialization;

namespace MethodImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Introduction();
            
            Console.ReadLine();
            
        }
        static void Introduction ()
        {
            Console.WriteLine( "Enter YOur Name :" );
           string Name = (Console.ReadLine());
            Console.WriteLine("Enter your age :");
             int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hii Your Are Is " + Age  +  " Your Name Is " +  Name);



        }
    }
}
