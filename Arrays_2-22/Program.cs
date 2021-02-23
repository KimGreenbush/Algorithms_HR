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