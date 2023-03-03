namespace Develop02;

public class Entry
{
    public string _response = "";                            //Variable for the entry of user
    public List<string> _entryList = new List<string>();     //Created list for each entry and date for each
    
    public Entry() 
    {
    }
    
    public void InstanceEntry()
    {
        Random randomgen = new Random();
        int _prompt = randomgen.Next(1,6);        //Random Number generator
        
        if (_prompt == 1)                         //Each random question the program may ask
        { Console.Write("Who was the most interesting person I interacted with today?\n"); }
        else if (_prompt == 2)
        { Console.Write("What was the best part of my day?\n"); }
        else if (_prompt == 3)
        { Console.Write("How did I see the hand of the Lord in my life today?\n"); }
        else if (_prompt == 4)
        { Console.Write("What was something you did to lend service today to other people?\n"); }
        else if (_prompt == 5)
        { Console.Write("What did you learn by reading the Book of Mormon today?\n"); }
        else
        { Console.Write("How was your nutrition today and did you hit your calorie count?\n"); }
        
        DateTime date = DateTime.Now;
        _response = Console.ReadLine();                      //Stores the user's input
        
        _response = ($"{date} \n {_response}");              //Adds the date to the response and puts it in list
        _entryList.Add(_response);
    }

    public void DisplayEntries()
    {
        
        foreach (var _response in _entryList)           //Loop to write all items in list
            Console.WriteLine(_response);
        
    }

}
