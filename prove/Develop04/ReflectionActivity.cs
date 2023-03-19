namespace Develop04;

public class ReflectionActivity : Activity
{
    public List<string> Prompts { get; set; }
    
    public List<string> Questions { get; set; }
    
    public override void RunActivity()
    {
        Console.WriteLine($"Welcome to the {Name}.");
        Console.WriteLine($"{Description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string userInput = Console.ReadLine();
        Duration = int.Parse(userInput);
        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);
        
        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{Prompts[promptIndex]}---");
        Thread.Sleep(3000);
        
        int _duration = Duration;
        for (int i = 0; i < Questions.Count; i++)
        {
            if (_duration > 0)
            {
                Console.WriteLine(Questions[i]);
                Thread.Sleep(1000);


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
                _duration = _duration - 4;
            }
            else
            {
                i = Questions.Count;
            }
        }
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {Duration} seconds of the {Name}");
    }
}