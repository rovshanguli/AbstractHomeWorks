using System;
using System.Collections.Generic;
using System.Text;

namespace Computers
{
    class Asus : NoteBooks
    {
        public override void parametrs(string Processor, int Memory, int Ram, double ScreenSize)
        {
            Console.WriteLine($"Processor : {Processor}");
            Console.WriteLine($"Memory : {Memory}");
            Console.WriteLine($"Ram : {Ram}");
            Console.WriteLine($"ScreenSize : {ScreenSize}");
        }

    }
}
