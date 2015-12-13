using System;

namespace Interface_Demo.Lib
{
    public class BaseClass
    {
        public int Sides { get; set; }
        public int Length { get; set; }

        //To fill in these props
        public BaseClass(int sides, int length)
        {
            Sides = sides;
            Length = length;
        }
        
        //Calculate Perimeter. Number of sides * Length of each side
        public int CalcPerimeter()
        {
            return Sides*Length;
        }

        //Area differs for different object. Hence, it is kept virtual method to get overriden 
        //in derived class

        public virtual int CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
