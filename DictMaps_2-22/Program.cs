using System;
using System.Collections.Generic;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Dictionary<string,string> PhoneBook = new Dictionary<string,string>();

        for (int i = 0; i < n; i++)
        {
            string[] arr = Console.ReadLine().Split(' ');

            PhoneBook.Add(arr[0], arr[1]);
        }

        String Query;

        while ((Query = Console.ReadLine()) != null)
        {
            if (PhoneBook.ContainsKey(Query))
            {
                Console.WriteLine($"{Query}={PhoneBook[Query]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}