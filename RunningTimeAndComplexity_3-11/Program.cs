using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int T = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int n = Int32.Parse(Console.ReadLine());
            int j = 2;
            bool prime = true;

            if (n < j)
            {
                prime = false;
            }

            while (j*j <= n)
            {
                if (n%j == 0)
                {
                    prime = false;
                    break;
                }
                j++;
            }

            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}