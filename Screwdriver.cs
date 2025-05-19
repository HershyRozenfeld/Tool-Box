using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Screwdriver : Tool
    {
        public override void Describe()
        {
            Console.WriteLine("Screwdriver – Turns screws to tighten or loosen them.");
        }
    }
}
