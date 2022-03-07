using System;

namespace ShapeAbstractChallange
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        double sideA = 0, sideB = 0;
        public Square(double sideA, double sideB, string Name, int Numsides) : base (Name, Numsides)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.SetArea();
        }
    }
}
