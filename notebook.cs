using System;

namespace cmdNotes
{
    class Notebook
    {
        private List<string> Notes = new List<string>();
        
        public void NewNote()
        {
            Console.WriteLine("What is your note?");
            string notetext = Console.ReadLine();
            Notes.Add(notetext);
            
        }
        public void PrintNotes()
        {
            if (Notes.Any())
            {
                int count = 1;
                Console.WriteLine("----------------");
                foreach (string note in Notes)
                {
                    Console.WriteLine($"{count}: {note}");
                    count++;
                }
                Console.WriteLine("----------------");
            }
            else
            {
                Console.WriteLine("No notes added yet");
            }
        }
        public void DeleteNote()
        {
            this.PrintNotes();
            Console.WriteLine("Which Note would you like to delete?");
            int index = Int32.Parse(Console.ReadLine());
            try
            {
                Notes.RemoveAt(--index);
            }
            catch
            {
                Console.WriteLine("No note with such index or invalid input");
            }
        }
        
    }

}
