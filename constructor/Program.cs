using System;

namespace Constructor
{

    class Vehicle 
    {

        string brand;
        int price;

        
        Vehicle(string theBrand, int thePrice)
        {

            brand = theBrand;
            price = thePrice;
        }

        static void Main(string[] args)
        {

        
            Vehicle car1 = new Vehicle("Bugatti", 50000);

            Console.WriteLine("Brand: " + car1.brand);
            Console.WriteLine("Price: " + car1.price);
            Console.ReadLine();

        }
    }
}




