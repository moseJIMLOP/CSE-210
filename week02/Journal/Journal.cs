public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    { 

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._date} -Prompt: {entry._promptText}");
                outputfile.WriteLine(entry._entryText);
                outputfile.WriteLine();
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (String line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
    }
}