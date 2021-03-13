using System;
using System.Collections.Generic;

class Solution
{
    //Write your code
    Stack<char> backwards = new Stack<char>();
    Queue<char> letters = new Queue<char>();

    void pushCharacter(char c)
    {
        backwards.Push(c);
    }

    void enqueueCharacter(char c)
    {
        letters.Enqueue(c);
    }

    char popCharacter()
    {
        return backwards.Pop();
    }

    char dequeueCharacter()
    {
       return letters.Dequeue();
    }


    static void Main(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}