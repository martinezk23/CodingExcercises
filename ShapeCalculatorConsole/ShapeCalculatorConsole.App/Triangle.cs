using System;

namespace ShapeAbstractChallange
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
            //s = (a+b+c)/2 (this is the semi-perimeter)
            //area = sqrt*(s(s-a)(s-b)*(s-c))
            double sideA=0, sideB=0, sideC=0;
            public Triangle( double sideA, double sideB, double sideC, string Name, int NumSides) : base (Name, NumSides)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.SetArea();
        }

        protected override void SetArea()
        {
            double s = (sideA + sideB + sideC)/ 2;
            base.Area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

        }

        public override void GetSidesInfo()
        {
            throw new NotImplementedException();
        }

        public override void GetAreaFormula()
        {
            throw new NotImplementedException();
        }
        
    }
}
