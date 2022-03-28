using System;

namespace ShapeAbstractChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Beep();

   
            //Triangle
         
            Triangle triangle = new Triangle("Triangle", 3, 4, 5, 6);
            triangle.GetInfo();
            triangle.GetSidesInfo();
            Console.WriteLine(triangle.GetArea());
       

            //Square

            //Rectangle

        }
    }
}
