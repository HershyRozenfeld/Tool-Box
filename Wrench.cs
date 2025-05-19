using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Wrench : Tool
    {
        public override void Describe()
        {
            Console.WriteLine("Wrench – Tightens or loosens nuts and bolts.");
        }
    }
}
