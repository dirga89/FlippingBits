using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        double temp;
        string binary = ToBinary(n);
        string flippedBinary;
        char[] cbin = new char[32];
        cbin = binary.ToCharArray();

        for(int i=0; i<32 ; i++)
        {
            temp = Char.GetNumericValue(cbin[i]);
            if(temp == 0)
            {
                cbin[i] = '1';
            }
            else
            {
                cbin[i] = '0';
            }
        }

        flippedBinary = new string(cbin);

        return Convert.ToInt64(flippedBinary,2);
    }

    public static string ToBinary(long x)
    {
        char[] buff = new char[32];
 
        for (int i = 31; i >= 0 ; i--)
        {
            int mask = 1 << i;
            buff[31 - i] = (x & mask) != 0 ? '1' : '0';
        }
 
        return new string(buff);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            //textWriter.WriteLine(result);
            Console.WriteLine(result.ToString());
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
