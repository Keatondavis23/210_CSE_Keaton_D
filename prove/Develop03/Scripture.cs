namespace Develop03;

public class Scripture
{
    private string _text;

    private List<Word> words = new List<Word>();

    public Scripture(string text)
    {
        _text = text;
        string[] splitWords = _text.Split(" ");
        foreach (string word in splitWords)
        {
            Word _word = new Word(word);
            words.Add(_word);
        }
    }

    public void HideWord()
    {
        Random rand = new Random();
        int index = rand.Next(words.Count());
        words[index].isHidden = true;

    }
    public Scripture()
    {
        words = new List<Word>();
    }
    public void DisplayScripture()
    {
        foreach (Word word in words)
        {
            word.Display();
        }
        
    }
    public bool AllWordsHidden()
    {
        var hidden = words.Where(word => word.isHidden == true);
        return hidden.Count() == words.Count() ? true : false;
        
    }
}