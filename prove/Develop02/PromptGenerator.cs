namespace Develop02;

public class PromptGenerator
{
    
    public string Prompt_Maker()
    {
        string prompt;
        Random randomgen = new Random();
        int _prompt = randomgen.Next(1, 6); //Random Number generator

        if (_prompt == 1) //Each random question the program may ask
        {
            prompt = "Who was the most interesting person I interacted with today?";
        }
        else if (_prompt == 2)
        {
            prompt = "What was the best part of my day?";
        }
        else if (_prompt == 3)
        {
            prompt = "How did I see the hand of the Lord in my life today?";
        }
        else if (_prompt == 4)
        {
            prompt = "What was something you did to lend service today to other people?";
        }
        else if (_prompt == 5)
        {
            prompt = "What did you learn by reading the Book of Mormon today?";
        }
        else
        {
            prompt = "How was your nutrition today and did you hit your calorie count?";
        }

        return prompt;

    }
}