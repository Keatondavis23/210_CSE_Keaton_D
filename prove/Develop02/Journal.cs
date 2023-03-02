using System;
using Develop02;

public class Journal
{
    public List<Entry> journal_entries = new List<Entry>();

    public void Display()
    {
        
        foreach (Entry entry in journal_entries)
        {
            entry.EntryInfo();
        }      
    } 
}