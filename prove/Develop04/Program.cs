using Develop04;

class Program
{
    static void Main()
    {

        ListingActivity listingActivity = new ListingActivity
        {
            Description =
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            Name = "Listing Activity",
            Prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            }
        };

        ReflectionActivity reflectionActivity = new ReflectionActivity
        {
            Description =
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            Name = "Reflection Activity",
            Prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            },
            Questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            }
        };

        BreathingActivity breathingActivity = new BreathingActivity

        {
            Description =
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            Name = "Breathing Activity"
        };
        
        int choice = 0;
        while (choice != 4)
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");


            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                breathingActivity.RunActivity();
            else if (choice == 2)
                reflectionActivity.RunActivity();
            else if (choice == 3)
                listingActivity.RunActivity();
            else if (choice == 4)
                Environment.Exit((0));
            else
                Console.WriteLine("Invalid choice!");
        }
    }
}
