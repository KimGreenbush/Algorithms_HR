using System;

class Solution
{

// Given an integer, , perform the following conditional actions:
// If  is odd, print Weird
// If  is even and in the inclusive range of 2 to 5, print Not Weird
// If  is even and in the inclusive range of 6 to 20, print Weird
// If  is even and greater than 20, print Not Weird

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        if ( N%2 == 1 || N >= 6 && N <= 20)
        {
            Console.WriteLine("Weird");
        }
        else if (N >= 2 && N <=5 || N > 20)
        {
            Console.WriteLine("Not Weird");
        }
    }
}
