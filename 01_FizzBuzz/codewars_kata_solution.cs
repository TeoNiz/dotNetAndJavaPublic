// solution code to kata: https://www.codewars.com//kata/57d814e4950d8489720008db/csharp

using System;
public class Kata
{
    public static double Index(int[] array, int n)
    {
        return (n >= array.Length) ? -1 : Math.Pow(array[n], n);
    }
}

// solution code to kata:

