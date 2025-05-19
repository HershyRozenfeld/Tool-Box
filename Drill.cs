using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Drill : Tool
    {
        public Drill() { }
        public Drill(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = Category;
        }
        public override void Describe()
        {
            Console.WriteLine("Drill – Makes holes in various materials using a rotating bit.");
        }
    }
}
