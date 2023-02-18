using System.Collections;
using System;

public class SMath
{
    public static double RoundToDigits(double d, int dig)
    {
        int cur_digs = ((int)Math.Log10(d) + 1);

        d *= Math.Pow(10, dig - cur_digs);
        d = Math.Round(d);
        d /= Math.Pow(10, dig - cur_digs);

        return d;
    }
}
