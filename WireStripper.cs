using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class WireStripper : Tool
    {
        public WireStripper() { }
        public WireStripper(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = Category;
        }
        public override void Describe()
        {
            Console.WriteLine("Wire Stripper – Removes insulation from electrical wires without damaging the metal inside.");
        }
    }
}
