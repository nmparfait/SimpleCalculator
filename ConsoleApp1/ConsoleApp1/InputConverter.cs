using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Excepted a numeric value.");
            return convertedNumber;
        }
    }
}
