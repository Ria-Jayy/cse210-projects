using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is currently empty.");
            return;
        }

        Console.WriteLine("\n========== YOUR JOURNAL ==========\n");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine($"Journal successfully saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("The file could not be found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length >= 4)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                string mood = parts[3];

                Entry entry = new Entry(date, prompt, response, mood);
                _entries.Add(entry);
            }
        }

        Console.WriteLine($"Journal successfully loaded from {filename}");
    }

    public int GetEntryCount()
    {
        return _entries.Count;
    }
}