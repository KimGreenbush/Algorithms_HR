﻿using System.Collections.Generic;
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

        int remainder;
        int count = 0;
        int max = 0;

        while (n > 0)
        {
            remainder = n % 2;
            n = n / 2;
            Console.WriteLine($"n: {n}");
            Console.WriteLine($"remainder:  {remainder}");
            if (remainder == 1)
            {
                count++;
                Console.WriteLine($"count: {count}");
            }
            else
            {
                if (max < count)
                {
                    max = count;
                }
                count = 0;
            }
        }
        if (count > max)
        {
            max = count;
        }
        Console.WriteLine(max);

    }
}