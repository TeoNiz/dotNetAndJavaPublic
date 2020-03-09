using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public static class FizzBuzzer
    {
        public static List<String> MillNumbers(List<int> numbers)
        {
            List<String> results = new List<String>();
            foreach(int number in numbers)
            {
                if (number % 5 == 0)
                    results.Add("Buzz");
                else
                    results.Add(number.ToString());
            }
            return results;
        }
    }
}
