using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo.Lib
{
  public abstract class AbstractBaseClass
    {
        public int Sides { get; set; }
        public int Length { get; set; }

        //To fill in these props
        public AbstractBaseClass(int sides, int length)
        {
            Sides = sides;
            Length = length;
        }

        //Calculate Perimeter. Number of sides * Length of each side
        public int CalcPerimeter()
        {
            return Sides * Length;
        }
        public abstract int CalcArea();
        
    }
}
