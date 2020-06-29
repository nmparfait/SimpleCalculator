using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;

            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "substract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }
            return result;
        }
    }
}
