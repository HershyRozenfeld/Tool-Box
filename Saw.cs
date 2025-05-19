using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Saw : Tool
    {
        public Saw() { }
        public Saw(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = "Cutting";
        }
        public override void Describe()
        {
            Console.WriteLine("Saw – Cuts wood, metal, or plastic using a toothed blade.");
        }
    }
}
