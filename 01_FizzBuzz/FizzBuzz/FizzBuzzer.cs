using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public static List<string> MillNumbers(List<int> numbers)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 3 == 0)
                    result.Add("Fizz");
                else
                    result.Add(numbers[i].ToString());
            }
            return result;
        }
    }
}
