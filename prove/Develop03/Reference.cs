namespace Develop03;

public class Reference
{
    private string _reference;

    public Reference(string reference)
    {
        _reference = reference;
    }

    public void displayReference()
    {
        Console.WriteLine(_reference);
    }
}