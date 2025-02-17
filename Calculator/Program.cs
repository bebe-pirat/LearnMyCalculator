using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMyCalculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int? Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
                return null;
            }
        }

        static public double CircleArea(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
