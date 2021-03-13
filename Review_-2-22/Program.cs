using System;
class Solution
{
    static void Main(String[] args)
    {
        int numOfWords = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numOfWords; i++)
        {
            string word = Console.ReadLine();
            string FirstHalf = "";
            string SecHalf = "";
            int j = 0;
            while (j < word.Length)
            {
                if (j % 2 == 0)
                {
                    FirstHalf += word[j];
                }
                else
                {
                    SecHalf += word[j];
                }
                j++;
            }
            Console.WriteLine($"{FirstHalf} {SecHalf}");
        }
    }
}