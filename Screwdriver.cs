using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Screwdriver : Tool
    {
        public Screwdriver() { }
        public Screwdriver(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = Category;
        }
        public override void Describe()
        {
            Console.WriteLine("Screwdriver – Turns screws to tighten or loosen them.");
        }
    }
}
