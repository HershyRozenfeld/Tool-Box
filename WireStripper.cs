using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class WireStripper : Tool
    {
        public override void Describe()
        {
            Console.WriteLine("Wire Stripper – Removes insulation from electrical wires without damaging the metal inside.");
        }
    }
}
