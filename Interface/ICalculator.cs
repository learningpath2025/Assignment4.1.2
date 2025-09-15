using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1._2.Interface
{
    internal interface ICalculator
    {
        double Add(double firstNumber, double secondNumber);
        double Subtract(double firstNumber, double secondNumber);
        double Multiply(double firstNumber, double secondNumber);
        double Divide(double firstNumber, double secondNumber);
    }
}
