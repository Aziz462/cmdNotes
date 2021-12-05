using System;

namespace cmdNotes
{
    public class Program
    {
        static List<string> Notes = new List<string>();
        static public void Main()
        {
            
        }
        private void NewNote()
        {
            string notetext = Console.ReadLine();
            Program.Notes.Add(notetext);
        }
    }

}
