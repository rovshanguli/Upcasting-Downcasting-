using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingAndDownCastingPracties.Models
{
    abstract class NoteBooks
    {
        public abstract void Run();
        public virtual void Ram()
        {
            Console.WriteLine("NoteBook's Ram");
        }
    }
}
