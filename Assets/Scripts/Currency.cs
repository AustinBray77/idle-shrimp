using System;
using UnityEngine;

public struct Currency
{
    private double value;

    public Currency(double value)
    {
        if (value < 0)
        {
            value = 0;
        }

        this.value = value;
    }

    public static Currency operator +(Currency a, double b)
    {
        if (b < 0)
        {
            b = 0;
        }

        return new Currency(a.value + b);
    }

    public static Currency operator -(Currency a, double b)
    {
        if (b < 0)
        {
            b = 0;
        }

        return new Currency(a.value - b);
    }

    public override string ToString()
    {
        int digitsFrom = (int)Math.Floor(Math.Floor(Math.Log(value, 10)) / 3);
        return SMath.RoundToDigits(value / Math.Pow(10, (digitsFrom * 3)), 3).ToString() + ((char)(digitsFrom + 97)).ToString();
    }
}