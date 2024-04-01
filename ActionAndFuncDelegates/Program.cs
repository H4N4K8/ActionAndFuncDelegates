using System;
using static Assignment8ex2.MathSolutions;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public delegate void calculateProduct(double x, double y);
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            answer.GetSmaller(num1, num2);

            Func <double, double, double> calculate = GetSum;
            Console.WriteLine($"Addition of 5 and 10 is : {calculate(num1, num2)}");

            Action<double, double> smaller = GetSmaller;
            Console.WriteLine(smaller + " is the smaller number");

            calculateProduct d1 = new calculateProduct(MathSolutions.GetProduct);
            Console.WriteLine($"Product of numbers is: {d1(num1, num2)}");
        }
    }
}