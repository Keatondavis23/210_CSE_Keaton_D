using System;

using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        Console.Write("Please slect one of the following choices:",
        "\n1. Write",
        "\n2. Display",
        "\n3.Load",
        "\n4.Save",
        "\n5.Quit",
        "\nWhat would you like to do?");
        string selection1 = Console.ReadLine();
        selection = int.Parse(selection1);
        while (selection != 5){
        
            if(selection ==1)
            
            {


                Entry entry1 = new Entry();

                Random randomgen = new Random();
                int number = randomgen.Next(1,6);

                if (number == 1)
                {
                    Console.Write($"Enter the date, then respond:\nWho was the most interesting person I interacted with today?");
                    entry1.Response = Console.ReadLine();            
                }
                else if (number == 3)
                {
                    Console.Write($"Enter the date, then respond:\nWhat was the best part of my day?");
                    entry1.Response = Console.ReadLine();
                }
                else if (number == 4)
                {
                    Console.Write($"Enter the date, then respond:\nHow did I see the hand of the Lord in my life today?");
                    entry1.Response = Console.ReadLine();
                }
                else if (number == 5)
                {
                    Console.Write($"Enter the date, then respond:\nWhat were 3 things you did to lend service today to other people?");
                    entry1.Response = Console.ReadLine();
                }
                else
                {
                    Console.Write($"Enter the date, then respond:\n What did you learn by reading the Book of Mormon today?");
                    entry1.Response = Console.ReadLine();
                }
                Journal journal1 = new Journal();
                journal1.journal_entries.Add(entry1);
            }



            else if (selection == 2)
            {
                //Journal journal2 = new Journal();
                //foreach (entry1 in journal2);
                //{
                    //Console.WriteLine(entry1);
                //}
                Console.WriteLine("Win");
            }



            else if (selection ==3)
            {
                //here in this code you would load the entries 
                //that were written to a file location
            }

            else if (selection ==4)
            {
                //here in this code you would save the entries 
                //that were written to a file location
            }

        }
    }
}