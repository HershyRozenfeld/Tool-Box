using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Hammer : Tool
    {
        private int UseCount = 0;
        public Hammer() { }
        public Hammer(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = Category;
        }
        public override void Describe()
        {
            Console.WriteLine("Hammer – Used to drive nails or break objects with force.");
        }
    }
}
