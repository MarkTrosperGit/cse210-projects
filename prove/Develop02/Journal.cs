using System.Collections.Generic;
using System.Text;


public class Journal
{
    public List<Entry> _entries;
    //public string _journalDate = DateTime.Now.ToShortDateString();

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry recentEntry)
    {
        _entries.Add(recentEntry);
        Console.WriteLine("Entry Added! Great work, journaling today!");
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.getEntry());
        }
    }

    public string GetEntries()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Entry entry in _entries)
        {
            sb.AppendLine(entry.getEntry());
        }
        return sb.ToString();
    }
}
