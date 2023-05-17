using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Operation_s
{
     class newstring
    {
        static void Main(string[] args)
        {
            String Name = "Abhi";
            //To find the Length Of String 
            Console.WriteLine(Name.Length);
            // To Convert String TO UpperCase
            Console.WriteLine(Name.ToUpper());
            //To Convert String TO LoverCase
            Console.WriteLine(Name.ToLower());
            //String Concatination Method 1
            Console.WriteLine(Name + "Hello" );
            //String Concat. useing String concat Method
            Console.WriteLine(String.Concat(Name ," How Are You "));
        }
    }
}
