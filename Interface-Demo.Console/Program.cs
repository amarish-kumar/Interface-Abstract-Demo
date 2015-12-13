using Interface_Demo.Lib;

namespace Interface_Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(4,4);
            DisplayDimensions("Square", square);

            var squareAbstract= new SquareAbstract(4,4);
            DisplayDimensions("Square with abstract Implementation",squareAbstract);

            System.Console.ReadLine();
        }

        private static void DisplayDimensions(string objectType, dynamic square)
        {
            System.Console.WriteLine("Displaying Dimensions of " +objectType);
            System.Console.WriteLine("Number of Sides:- "+square.Sides);
            System.Console.WriteLine("Length of Each Side:- " + square.Length);
            System.Console.WriteLine("Area of " + objectType + " is " + square.CalcArea());
            System.Console.WriteLine("Perimeter of " + objectType + " is " + square.CalcPerimeter());
            System.Console.WriteLine("==============================================================");
            

        }
    }
}
