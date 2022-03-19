using System;

namespace cmdNotes
{
    public class Program
    {
    public static void Main()
        {
            Notebook notesObject = new Notebook(); 

            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.Write("Choose an action\nA - Add a note\nP - Print all current notes\nD - delete a note\n");
                string userChoice = Console.ReadLine();
                if (userChoice.ToUpper() == "A")
                {
                    notesObject.NewNote();
                }
                else if (userChoice.ToUpper() == "P")
                {
                    notesObject.PrintNotes();
                }
                else if (userChoice.ToUpper() == "D")
                {
                    notesObject.DeleteNote();
                }
                else
                {
                    Console.Write("-------------\nInvalid Input\n-------------\n");
                }
            }
        }

    }

}
