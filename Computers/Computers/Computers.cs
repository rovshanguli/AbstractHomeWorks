using System;
using System.Collections.Generic;
using System.Text;

namespace Computers
{
    public abstract class Computers
    {
        public string Processor { get; set; }
        public int Memory { get; set; }
        public int Ram { get; set; }
        public double ScreenSize { get; set; }

        public abstract void parametrs(string Processor, int Memory, int Ram, double ScreenSize);
    }
}
