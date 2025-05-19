using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class NailGun : Tool
    {
        public NailGun() { }
        public NailGun(string Name, int Weight, bool Use, string Category) : base(Name, Weight, Use, Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = Category;
        }
        public override void Describe()
        {
            Console.WriteLine("Nail Gun – Drives nails quickly and powerfully using air, gas, or electricity.");
        }
    }
}
