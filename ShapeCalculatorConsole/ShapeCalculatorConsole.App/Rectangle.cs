using System;

namespace ShapeAbstractChallange
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.

        public Rectangle(string Name, int NumSides) : base(Name, NumSides)
        {
        }

        public override void GetAreaFormula()
        {
            throw new NotImplementedException();
        }

        public override void GetSidesInfo()
        {
            throw new NotImplementedException();
        }

        protected override void SetArea()
        {
            throw new NotImplementedException();
        }
    }
}
