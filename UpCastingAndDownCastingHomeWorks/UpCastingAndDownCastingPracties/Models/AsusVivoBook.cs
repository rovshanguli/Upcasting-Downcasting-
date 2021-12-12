using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingAndDownCastingPracties.Models
{
    class AsusVivoBook : Asus
    {
        public int ScreenSize { get; set; }
        public override void Run()
        {
            
        }
        public override void Ram()
        {
            Console.WriteLine("Asus VivoBook's Ram ");
        }
    }
}
