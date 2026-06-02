using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        int userChoice = 0;

        while (userChoice != 5)
        {
            userChoice = Menu.DisplayMenu();
        
            if (userChoice == 1) 
            {
                JournalEntry myJournalEntry = new JournalEntry();
                myJournalEntry.CreateJournalEntry();
                myJournal.AddJournalEntry(myJournalEntry);
                Console.WriteLine("Entry added successfully");
            }
    
            else if (userChoice == 2)
            {
                myJournal.DisplayJournal();
            }
    
            else if (userChoice == 3)
            {
                myJournal.Upload();
            }
            else if (userChoice == 4)
            {
                myJournal.Save();
            }
        }    
    }


}