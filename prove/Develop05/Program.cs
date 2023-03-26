namespace Develop05;
class Program 
{
    static void Main()
    {
        int choice = 0;
        while (choice != 4)
        {
            EternalQuest quest = new EternalQuest();
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            choice = int.Parse(Console.ReadLine());

            
            int choiceGoal;
            string name, description;
            int points, targetCount;
            // Different options to create goals
            if (choice == 1)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.WriteLine("Which goal would you like to create?");
                
                choiceGoal = int.Parse(Console.ReadLine());
                if (choiceGoal == 1) {
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    points = int.Parse(Console.ReadLine());
                    
                    quest.AddGoal(new SimpleGoal(name, description, points));

                }
                else if (choiceGoal == 2) {
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    points = int.Parse(Console.ReadLine());
                    
                    quest.AddGoal(new EternalGoal(name, description, points));
                }
                else if (choiceGoal == 3) {
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    points = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times would you like to complete this goal?");
                    targetCount = int.Parse(Console.ReadLine());
                    
                    quest.AddGoal(new ChecklistGoal(name, description, points, targetCount));
                }
            } 
                
            else if (choice == 2)
            {
                quest.DisplayStatus();
            }
                
            else if (choice == 3){}
                
            else if (choice == 4){}
                
            else if (choice == 5)
            {
                Console.WriteLine("What goal did you accomplish?");
                name = Console.ReadLine();
                quest.RecordEvent(name);
            }
                
            else if (choice == 6){Environment.Exit(0);}
                
            else Console.WriteLine("Invalid choice!");
            
                
        }
        
        
        
        
        
        
        
        
        
        
    
    // Add some example goals
    // quest.AddGoal(new SimpleGoal("Run a Marathon", 1000));
    // quest.AddGoal(new EternalGoal("Read Scriptures", 100));
    // quest.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));
    //
    // // Record some progress on the goals
    // quest.RecordEvent("Read Scriptures");
    // quest.RecordEvent("Read Scriptures");
    // quest.RecordEvent("Attend Temple");
    // quest.RecordEvent("Attend Temple");
    // quest.RecordEvent("Attend Temple");
    // quest.RecordEvent("Attend Temple");
    // quest.RecordEvent("Attend Temple");
    // quest.RecordEvent("Attend Temple");
    // // Display the current status of the goals
    // quest.DisplayStatus();
}}