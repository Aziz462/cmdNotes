using System;

namespace cmdNotes
{
    public class Program
    {
        static List<string> Notes = new List<string>();
        
        private static void NewNote()
        {
            string notetext = Console.ReadLine();
            Program.Notes.Add(notetext);
            
        }
        private static void PrintNotes()
        {
            int count = 1;
            Console.WriteLine("----------------");
            foreach (string note in Program.Notes)
            {
                Console.WriteLine($"{count}: {note}");
                count++;
            }
            Console.WriteLine("----------------");
        }
        public static void Main()
        {
            while (true)
            {
                Console.Write("Choose an action\nA - Add a note\nP - Print all current notes\n");
                string userChoice = Console.ReadLine();
                if (userChoice.ToUpper() == "A")
                {
                    Console.WriteLine("Type your note:");
                    NewNote();
                }
                else if (userChoice.ToUpper() == "P")
                {
                    PrintNotes();
                }
                else
                {
                    Console.Write("-------------\nInvalid Input\n-------------\n");
                }
            }
        }
    }

}
