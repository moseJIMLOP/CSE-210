using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("3 Nephi", 17, 7);
        string verseText = "Have ye any that are sick among you? Bring them hither. Have ye any that are lame, or blind, or halt, or maimed, or leprous, or that are withered, or that are deaf, or that are afflicted in any manner? Bring them hither and I will heal them, for I have compassion upon you; my bowels are filled with mercy.";

        string[] wordsArray = verseText.Split(' ');
        List<Word> words = new List<Word>();

        foreach (string word in wordsArray)
        {
            words.Add(new Word(word));
        }

        Scripture scripture = new Scripture(reference, words);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue, or type 'quit' to quit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine("Good Job!");
    }
}