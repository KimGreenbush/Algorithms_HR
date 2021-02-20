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

        int total = 0;
        for (int i = 1; i <= 10; i++)
        {
            total = i * n;
            Console.WriteLine($"{n} x {i} = {total}");
        }
    }
}