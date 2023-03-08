using System.IO;
using System.Runtime.InteropServices.JavaScript;
using Develop02;

class Journal
{
    List<Entry> entries;              //Created list for each entry and date for each

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }//Loop to write all items in list
    }
    
    public void CreateEntry()
    {
        PromptGenerator MyPrompt = new PromptGenerator();
        string prompt = MyPrompt.Prompt_Maker();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        DateTime date1 = DateTime.Now;
        string date = date1.ToShortDateString();
        Entry entryx = new Entry(date, prompt, response);

    }
    
    
    
    
    public void FileCreate()                 //Writing and creating a file
    {

        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            records.Add(entry.getEntryAsCSV());
        }
        Console.WriteLine("Name of the file to save?:");
        string _fileName = Console.ReadLine();
        
        File.WriteAllLines(_fileName, records);
    }
        
    public void FileRead() {
        Console.WriteLine("Name of file to load?:");
        string _fileName = Console.ReadLine();

        List<string> records = System.IO.File.ReadAllLines(_fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split("|");
            Entry entry = new Entry(splitString[0], splitString[0], splitString[0]);
            entries.Add(entry);
        }

        //Console.ReadKey();
    }
    
}