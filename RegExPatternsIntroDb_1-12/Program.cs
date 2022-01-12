using System;

namespace RegExPatternsIntroDb_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string firstName = firstMultipleInput[0];

                string emailID = firstMultipleInput[1];
            }
        }
    }
}
