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

            // Hi, come, new  here - ----> here come , new , Hi 
            string currWord = string.Empty;
            Random newPosition = new Random(); //create an Object of type Random            

            for (int i = 0; i < words.Count; i++)
            {
                int position = newPosition.Next(0, words.Count);  // takes in Range 0 .. Count-1
                currWord = words[i];  // We keep here the currWord
                words[i] = words[position]; // We change the value of current Word 
                words[position] = currWord;

            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
