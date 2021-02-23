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

class Solution
{



    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        string ReverseWords = "";

        for (int i = arr.Length - 1; i > 0; i--)
        {
            ReverseWords += arr[i] + " ";
        }
        ReverseWords += arr[0];
        Console.WriteLine(ReverseWords);
    }
}