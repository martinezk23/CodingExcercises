using System;

namespace ShapeAbstractChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Triangle
           /* Console.WriteLine($"This is Triangle");
            Triangle trinagle = NewTriangle;
            NewTriangle = new Triangle("Triangle", 3, 4, 5, 6);
            triangle.GetInfo();*/
            Triangle triangle = new Triangle("Triangle", 3, 4, 5, 6);
            triangle.GetInfo();
            Console.WriteLine(triangle.GetArea());


            //Square

            //Rectangle

        }
    }
}
