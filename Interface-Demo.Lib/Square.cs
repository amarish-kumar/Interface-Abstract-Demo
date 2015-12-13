using System;
namespace Interface_Demo.Lib
{
   public class Square : BaseClass
    {
        public Square(int sides, int length) : base(sides, length)
        {
        }

        public override int CalcArea()
        {
            return Sides*Length;
        }
    }
}
