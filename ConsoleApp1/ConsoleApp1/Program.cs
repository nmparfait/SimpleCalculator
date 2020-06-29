using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputconverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Insert the first number");
                double firstNumber = inputconverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Insert the second number");
                double secondNumber = inputconverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Insert the operational sign");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);

                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
