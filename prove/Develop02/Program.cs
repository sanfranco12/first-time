using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        entry1._date = "";
        entry1._promptText = "Who was the most interesting person I interacted with today? ";        
        entry1._entryText = "";

        Entry entry2 = new Entry();
        entry2._date = "";
        entry2._promptText = "How did I see the hand of the Lord in my life today?";
        entry2._entryText = "";

        Entry entry3 = new Entry();
        entry3._date = "";
        entry3._promptText = "What scripture came to my mind during the day? ";
        entry3._entryText = "";

        Entry entry4 = new Entry(); 
        entry4._date = "";
        entry4._promptText = "What was the best part of my day?";
        entry4._entryText = "";

        Entry entry5 = new Entry();
        entry5._date = "";
        entry5._promptText = "What was the strongest emotion I felt today?";
        entry5._entryText = "";

        List<Entry> entries = new List<Entry>();
        entries.Add(entry1);
        entries.Add(entry2);
        entries.Add(entry3);
        entries.Add(entry4);
        entries.Add(entry5);

        foreach (Entry e in entries)
        {
            Console.WriteLine(e._promptText);
        }

        SaveToJournal(entries);

        List<Entry> newEntries = ReadFromJournal();
        foreach (Entry e in newEntries)
        {
            Console.WriteLine(e._promptText);
        }
    }

    public static void SaveToJournal(List<Entry>entries)
    {
        Console.WriteLine("suposed to save in files");
        string filename = "MyJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._promptText}|{e._entryText}|{e._date}");
            }
        }
    }

    public static List<Entry> ReadFromJournal()
    {
        Console.WriteLine("This is supposed to read list from file");
        List<Entry> entries = new List<Entry>();
        string filename = "MyJournal.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
        return entries;
        
    }
}