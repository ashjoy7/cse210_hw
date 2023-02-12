using System;
using System.Collections.Generic;

namespace ScriptureMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store the scripture reference and text
            string reference = "John 3:16";
            string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

            // Split the text into an array of words
            string[] words = text.Split(' ');

            // Create a list to track which words are hidden
            List<int> hiddenWords = new List<int>();

            while (hiddenWords.Count < words.Length)
            {
                // Clear the console screen
                Console.Clear();

                // Display the scripture, with hidden words replaced by asterisks
                for (int i = 0; i < words.Length; i++)
                {
                    if (hiddenWords.Contains(i))
                    {
                        Console.Write("*** ");
                    }
                    else
                    {
                        Console.Write(words[i] + " ");
                    }
                }

                Console.WriteLine("\n\n" + reference);

                // Prompt the user to press the enter key or type quit
                Console.Write("\nPress enter to hide another word, or type quit to end: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    // Select a random word to hide
                    Random random = new Random();
                    int index = random.Next(0, words.Length);
                    hiddenWords.Add(index);
                }
            }
        }
    }
}
