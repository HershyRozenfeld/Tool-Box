using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class PipeCutter : Tool
    {
        public PipeCutter() { }
        public PipeCutter(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = "Cutting";
        }
        public PipeCutter(bool Use){
            use = Use;
        }
        public override void Describe()
        {
            Console.WriteLine("Pipe Cutter – Cuts pipes cleanly and precisely, usually for plumbing.");
        }
    }
}
