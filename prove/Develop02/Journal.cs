using System.IO; 
using Develop02;

public class Journal
{
    private string _filename = "";
    public Journal()
    {
    }

    public void FileCreate()                 //Writing and creating a file
    {
        Console.Write("What do you want to name the file?:\n");  //Stores name of new file
        _filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(_filename)) //Creates new file with name given
        {
            foreach (var _response in _entrylist)                     //Creates a loop to put every entry from our list
            {                                                         //into the new file
                outputFile.WriteLine(_response);
            }
        }
    }
    
    public void FileRead()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        //??????????????????????????????????
    }
    
}