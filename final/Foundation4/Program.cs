namespace Foundation4;
class Program
    {
        static void Main(string[] args)
        {
            RunningActivity running = new RunningActivity(DateTime.Parse("09/05/2023"), 10, 4.5);
            CyclingActivity cycling = new CyclingActivity(DateTime.Parse("01/05/2023"), 90, 30);
            SwimmingActivity swimming = new SwimmingActivity(DateTime.Parse("10/05/2022"), 120, 20);

            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

        }
    }
