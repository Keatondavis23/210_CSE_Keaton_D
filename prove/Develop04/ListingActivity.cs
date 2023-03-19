namespace Develop04;

public class ListingActivity : Activity
{
    public List<string> Prompts { get; set; }
    
    public override void RunActivity()
    {
        Console.WriteLine($"Welcome to the {Name}.");
        Console.WriteLine($"{Description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string userInput = Console.ReadLine();
        Duration = int.Parse(userInput);
        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine($"---{Prompts[promptIndex]}---");
        
        Thread.Sleep(3000);

        int _duration = Duration;
        int itemCount = 0;
        
        while (_duration > 0)
        {
            string input = Console.ReadLine();
            itemCount++;
            _duration = _duration - 3;
        }
        
        Console.WriteLine($"You listed {itemCount} items\n");
        
        Console.WriteLine("Well done!!\n");
        Console.CursorLeft = 0;
        Console.Write("|");
        Thread.Sleep(1000);
        Console.CursorLeft = 0;
        Console.Write("/");
        Thread.Sleep(1000);
        Console.CursorLeft = 0;
        Console.Write("-");
        Thread.Sleep(1000);
        Console.CursorLeft = 0;
        Console.Write("");
        Thread.Sleep(0);
        
        Console.WriteLine($"You have completed another {Duration} seconds of the {Name}");
    }
}