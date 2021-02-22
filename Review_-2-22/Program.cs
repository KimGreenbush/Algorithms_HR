using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string[] words = args;
        string word = Console.ReadLine();
        string FirstHalf = "";
        string SecHalf = "";
        int i = 0;
        while (i < word.Length)
        {
            if (i % 2 == 0)
            {
                FirstHalf += word[i];
            }
            else
            {
                SecHalf += word[i];
            }
            i++;
        }
        Console.WriteLine($"{FirstHalf} {SecHalf}");
    }
}