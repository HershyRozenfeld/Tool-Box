using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Drill : Tool
    {
        public override void Describe()
        {
            Console.WriteLine("Drill – Makes holes in various materials using a rotating bit.");
        }
    }
}
