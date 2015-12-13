namespace Interface_Demo.Lib
{
   public class SquareAbstract : AbstractBaseClass
    {
       public SquareAbstract(int sides, int length) : base(sides, length)
       {
       }

       public override int CalcArea()
       {
           return Sides * Length;
       }
    }
}
