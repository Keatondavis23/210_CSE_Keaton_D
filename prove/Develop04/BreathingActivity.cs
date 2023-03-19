namespace Develop04;

public class BreathingActivity : Activity
{
    
    public override void RunActivity()
    {
        
        Console.WriteLine($"Welcome to the {Name}.");
        Console.WriteLine($"{Description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string userInput = Console.ReadLine();
        Duration = int.Parse(userInput);
        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);

        int _duration = Duration;
        while (_duration > 0)
        {
            Console.WriteLine("Breathe in...");
            Console.CursorLeft = 0;
            Console.Write("2");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("1");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("");

            Console.WriteLine("Breathe out...");
            Console.CursorLeft = 0;
            Console.Write("4");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("3");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("2");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("1");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("");

            _duration = _duration - 9;
        }

        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {Duration} seconds of the {Name}");
    }
}