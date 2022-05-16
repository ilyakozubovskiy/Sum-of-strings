using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        if (string.IsNullOrWhiteSpace(a))
            a = "0";
        if (string.IsNullOrWhiteSpace(b))
            b = "0";

        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}