using System;
using System.Globalization;
using Develop03;

class Program
{
    static void Main()
    {

        bool done = false;
        Reference reference = new Reference("John 3:16");
        Scripture scripture = new Scripture(
            "For God so loved the world that he gave his one" +
            " and only Son, that whoever believes in him shall" +
            " not perish but have eternal life.");
        
        
        Console.Clear();
        reference.displayReference();
        scripture.DisplayScripture();
        while (!done)
        {
            
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                done = true;
            }

            Console.Clear();
            scripture.HideWord();
            scripture.DisplayScripture();
            
            if (scripture.AllWordsHidden())
            { 
                Console.WriteLine("Congratulations, you have memorized the scripture!");
                done = true;
            }
        }
    }
}
