using System.Numerics;

namespace Task_1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Operator.Add(10, 5);
            Operator.Subtract(10, 5);
            Operator.Multiply(10, 5);
            Operator.Divide(10, 5);
            Operator.OddEvenFinder(10);
            Operator.OddEvenFinder(7);

        }

        
    }
}
