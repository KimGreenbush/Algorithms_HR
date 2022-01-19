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

class Solution
{
    public static void Main(string[] args)
    {
        Regex gmail = new Regex("[a-z]+@gmail.com");

        List<KeyValuePair<string, string>> emails = new List<KeyValuePair<string, string>>();

        int N = Convert.ToInt32(Console.ReadLine().Trim());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];

            if (gmail.IsMatch(emailID))
            {
                KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(firstName, emailID);
                emails.Add(kvp);
            }
        }
        var sortedEmails = emails.OrderBy(email => email.Key);
        foreach (KeyValuePair<string, string> email in sortedEmails)
        {
            Console.WriteLine(email.Key);
        }
    }
}
