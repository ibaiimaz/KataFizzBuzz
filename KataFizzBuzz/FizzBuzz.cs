using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public string GetNumberConversion(int number)
        {
            string outputString = ReturnStringIfMatch(number);

            return ReturnNumberOrConversion(number, outputString);
        }

        private string ReturnNumberOrConversion(int number, string outputString)
        {
            return outputString != null ? outputString : number.ToString();
        }

        private string ReturnStringIfMatch(int number)
        {
            string outputString = null;

            if (DivisibleByThree(number) || ContainsThree(number))
                outputString = "Fizz";
            if (DivisibleByFive(number) || ContainsFive(number))
                outputString += "Buzz";

            return outputString;
        }

        private bool ContainsFive(int number)
        {
            return number.ToString().Contains("5");
        }

        private bool ContainsThree(int number)
        {
            return number.ToString().Contains("3");
        }

        private bool DivisibleByFive(int number)
        {
            return number%5 == 0;
        }

        private bool DivisibleByThree(int number)
        {
            return number%3 == 0;
        }
    }
}
