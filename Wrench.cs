using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Wrench : Tool
    {
        public Wrench() { }
        public Wrench(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = Category;
        }
        public override void Describe()
        {
            Console.WriteLine("Wrench – Tightens or loosens nuts and bolts.");
        }
    }
}
