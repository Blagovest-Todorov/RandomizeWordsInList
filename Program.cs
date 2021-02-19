using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList(); // receive words -split them into a List of strings

            // Hi, come, new  here
            string currWord = string.Empty;
            Random newPosition = new Random(); //create an Object of type Random
            

            for (int i = 0; i < words.Count; i++)
            {
                int position = newPosition.Next(0, words.Count);  // in Range 0 .. count-1

                currWord = words[i];  // We keep here the currWord

                words[i] = words[position]; // We change the value od current Word 
                words[position] = currWord;

            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
