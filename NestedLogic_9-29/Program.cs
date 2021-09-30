using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    static Func<string[], int[]> ConvertToIntArray = array =>
    {
        int[] newArray = new int[3];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = Convert.ToInt32(array[i]);
        }

        return newArray;
    };

    static void Main(String[] args)
    {
        string[] returnedDate = Console.ReadLine().Split(" ");
        string[] dueDate = Console.ReadLine().Split(" ");

        int[] intDate = ConvertToIntArray(returnedDate);

        //code

        // is it late?
        // no,  return date <= due date
        // yes, return date > due date

        // not late no fine! fine = 0

        // late, calculate fine
        // days, 15 hackos * days
        // months, 500 hackos * month
        // years, 10000 hackos fixed

    }
}