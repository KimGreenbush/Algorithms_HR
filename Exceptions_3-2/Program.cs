using System;
class Solution
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();

        try
        {
            Console.WriteLine(Convert.ToInt32(S));
        }
        catch (Exception e)
        {
            Console.WriteLine("Bad String");
        }
    }
}
