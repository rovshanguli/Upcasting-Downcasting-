using System;
using UpCastingAndDownCastingPracties.Models;

namespace UpCastingAndDownCastingPracties
{
    class Program
    {
        static void Main(string[] args)
        {
            AsusVivoBook vivoBook = new AsusVivoBook();
            
            NoteBooks noteBooks = vivoBook;
            vivoBook.Ram();
            noteBooks.Ram();
            

        }
    }
}
