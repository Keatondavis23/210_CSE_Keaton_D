using System.Dynamic;

namespace Develop03;

public class Word
{
    public string _text;
    public string hiddentext = "";
    public bool isHidden { get; set; }

    
    public Word(string word)
    {
        _text = word;
        for (int i = 0; i < word.Length; i++)
        {
            hiddentext += "_";
        }
    }
    
    
    public void Display()
    {
        Console.Write(isHidden ? hiddentext + " " : _text + " ");
    }
    
}