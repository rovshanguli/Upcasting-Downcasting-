using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingAndDownCastingPracties.Models
{
    class AcerAspire : Acer
    {
        public int Memory { get; set; }
        public override void Run()
        {
            
        }
        public override void Ram()
        {
            Console.WriteLine("AcerAspire's Ram");
        }
    }
}
