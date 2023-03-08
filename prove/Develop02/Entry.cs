namespace Develop02;

public class Entry
{
    public string date, prompt, response;
    public string CompleteEntry;
    
    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
        
    }
    
    
    
    public string DisplayEntry()
    {
        CompleteEntry = ($"{date}\n{prompt}\n{response}"); 
        Console.WriteLine(date, prompt, response); 
        return CompleteEntry;     
    }

    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }

}
