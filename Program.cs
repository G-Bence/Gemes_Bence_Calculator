using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static double Adding(double value_a, double value_b)
        {    
            return value_a + value_b;
        }

        static double Subtraction(double value_a, double value_b)
        {
            return value_a - value_b;
        }

        static double Division(double value_a, double value_b)
        {
            return value_a / value_b;
        }

        static double Multiplying(double value_a, double value_b)
        {
            return value_a * value_b;
        }

        static double Percentage(double value_a, double value_b)
        {
            return value_b * (value_a/100);
        }

        static void Main(string[] args)
        {
        }
    }
}
