using System;

namespace Algorythms
{
    class Datatypes
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int j;
            double e;
            string t;

            // Read and save an integer, double, and String to your variables.
            Console.WriteLine("Insert an integer");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert an double");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert an string");
            t = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + j);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(d + e);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + t);

        }
    }
}
