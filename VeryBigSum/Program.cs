using System.IO;
using System;

class Solution
{

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar)
    {
        long BigSum = 0;
        foreach (long number in ar)
        {
            BigSum += number;
        }
        return BigSum;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        ;
        long result = aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}