using System;

class Solution
{

    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int hourglass, LargestHourglass = 0;
        for (int j = 0; j < arr.Length - 2; j++)
        {
            for (int k = 0; k < arr.Length - 2; k++)
            {
                hourglass = arr[j][k] + arr[j][k + 1] + arr[j][k + 2] + arr[j + 1][k + 1] + arr[j + 2][k] + arr[j + 2][k + 1] + arr[j + 2][k + 2];
                if (j == 0 && k == 0)
                {
                    LargestHourglass = hourglass;
                }
                if (hourglass > LargestHourglass)
                {
                    LargestHourglass = hourglass;
                    hourglass = 0;
                }
            }
        }
        Console.WriteLine(LargestHourglass);
    }
}