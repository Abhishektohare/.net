namespace useing_Return_Keyword_with_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x ;
            double y;
            double result;
            Console.WriteLine("Enter First NO. ");
            x= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second");
            y= double.Parse(Console.ReadLine());
            result=Addition(x,y);
            Console.WriteLine(result);



        }
       static double  Addition (double x, double y){
        double z = x+y;
        return z; 

       } 
    }
}