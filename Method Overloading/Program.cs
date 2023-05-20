

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_OVerloading
{
    class Program
    {
       public void Add(){
         int a=10; 
         int b =20;
         int c = a+b;
         System.Console.WriteLine( c);

       }
       public void Add(  int  a, int  b)
       {
      int c=  a+  b;
      System.Console.WriteLine(c);
}

       
      public void Add(float a, float b){
       float c = a+b;
       System.Console.WriteLine(c);
      }
      public void Add( String a , String b){
        String c = a + " " +  b;
        Console.WriteLine(c);
      } 
           
        static void Main(string[] args)
        {
            Program p=new Program();
           
           
            
            System.Console.WriteLine( );
            Program P = new Program();
            P.Add();
            P.Add(1,5);
            P.Add(2.5f,2.5f);
            P.Add("one","two");

              }
    }
}