using Assignment4._1._2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1._2.Implementation
{
    public class CalcMethods : ICalculator
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return firstNumber / secondNumber;
        }
    }
}
