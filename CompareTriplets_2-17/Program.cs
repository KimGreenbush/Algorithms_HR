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

    // Complete the compareTriplets function below.

    // The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

    // If a[i] > b[i], then Alice is awarded 1 point.
    // If a[i] < b[i], then Bob is awarded 1 point.
    // If a[i] = b[i], then neither person receives a point.
    // Comparison points is the total points a person earned.

    // Given a and b, determine their respective comparison points.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> score = new List<int>() {0,0};

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                score[0]++;
            }
            if (a[i] < b[i])
            {
                score[1]++;
            }
        }
            return score;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
