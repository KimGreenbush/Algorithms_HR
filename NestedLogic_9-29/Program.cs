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

    static int CalculateFine(int[] returnDate, int[] dueDate)
    {
        int fine = 0;

        if (returnDate[2] < dueDate[2])
        {
            return fine;
        }
        else if (returnDate[2] > dueDate[2])
        {
            fine = 10000;
        }
        else if (returnDate[1] > dueDate[1])
        {
            fine = 500 * (returnDate[1] - dueDate[1]);
        }
        else if (returnDate[0] > dueDate[0])
        {
            fine = 15 * (returnDate[0] - dueDate[0]);
        }

        return fine;
    }

    static void Main(String[] args)
    {
        string[] returnedDate = Console.ReadLine().Split(' ');
        string[] dueDate = Console.ReadLine().Split(' ');

        int[] intReturnedDate = ConvertToIntArray(returnedDate);
        int[] intDueDate = ConvertToIntArray(dueDate);

        //code

        int libraryFine = CalculateFine(intReturnedDate, intDueDate);

        Console.WriteLine(libraryFine);

    }
}