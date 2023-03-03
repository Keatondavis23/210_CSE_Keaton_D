using System;


//QUESTIONS
//How do you create a list that can be used through all 3 classes? Especially for writing to a file, and storing entries to it?
//Why my list isnt storing the _response variables I enter into it?

using System;
using Develop02;

class Program
{
    
    static void Main(string[] args)
    {
        
        
        
        int menuUserInput = 0;               //Variable storing the user's choice

        List<string> menu = new List<string> //This creates a list of options for the
            //user to chose from
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Load", //Options for program
                "4. Save",
                "5. Quit",
                "What would you like to do?"
            };
            
        while (menuUserInput != 5)                           //Program runs until user enters "5"
        {
            foreach (string menuItem in menu)                //Loop to write out all menu options
            { Console.WriteLine(menuItem); }
            
            menuUserInput = int.Parse(Console.ReadLine());   //This gives us a int of the input number

            
            //THIS IS WHERE THE DIFFERENT JOURNAL OPTIONS COME IN
            
            if (menuUserInput == 1)                          
            {                                                           //Provides the instance for the user
                Entry entry = new Entry();                              //to input a journal entry
                entry.InstanceEntry();
            }

            else if (menuUserInput == 2)
            {
                Entry display = new Entry();                            //Displays all journal entries
                display.DisplayEntries();
            }

            else if (menuUserInput ==3)
            {
                //here in this code you would load the entries 
                //that were written to a file location
            }

            else if (menuUserInput ==4)
            {
                //here in this code you would save the entries 
                //that were written to a file location
            }
        }
    }
}