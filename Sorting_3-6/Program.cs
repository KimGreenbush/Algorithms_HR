using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        // Write Your Code Here
        int totalNumberOfSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal
            int roundSwaps = 0;

            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j +1] = temp;
                    roundSwaps++;
                }
            }
            totalNumberOfSwaps += roundSwaps;
            // If no elements were swapped during a traversal, array is sorted
            if (roundSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Array is sorted in {totalNumberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[n-1]}");

    }
}