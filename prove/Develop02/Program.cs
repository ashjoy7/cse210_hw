using System;
using System.Collections.Generic;
using System.IO;

class JournalApp
{
    static List<JournalEntry> journalEntries = new List<JournalEntry>();
    static string[] prompts = { "What did you learn today?", "What are you grateful for?", "What is on your mind?", "What are your goals for tomorrow?", "What did you do well today?" };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add journal entry");
            Console.WriteLine("2. View journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("> ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddJournalEntry();
                    break;
                case 2:
                    ViewJournalEntries();
                    break;
                case 3:
                    SaveJournalToFile();
                    break;
                case 4:
                    LoadJournalFromFile();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddJournalEntry()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(0, prompts.Length);
        string prompt = prompts[promptIndex];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry(prompt, response, DateTime.Now);
        journalEntries.Add(entry);

        Console.WriteLine("Journal entry added.");
    }

    static void ViewJournalEntries()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No journal entries to view.");
        }
        else
        {
            foreach (JournalEntry entry in journalEntries)
            {
                Console.WriteLine("---");
                Console.WriteLine("Prompt: " + entry.Prompt);
                Console.WriteLine("Response: " + entry.Response);
                Console.WriteLine("Date: " + entry.Date);
            }
        }
    }

    static void SaveJournalToFile()
    {
        Console.WriteLine("Enter a file name:");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in journalEntries)
            {
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine(entry.Date);
            }
        }

        Console.WriteLine("Journal saved to " + fileName + ".");
    }

    static void LoadJournalFromFile()
    {
        Console.WriteLine("Enter a file name:");
        Console.Write
        