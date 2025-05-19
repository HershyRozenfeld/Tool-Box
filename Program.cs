using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            PipeCutter pipeCutter_1 = new PipeCutter();
            PipeCutter pipeCutter_2 = new PipeCutter();
            Screwdriver screwdriver = new Screwdriver();
            Saw saw = new Saw();
            hammer.Use();

            Tool[] tools = new Tool[] { hammer, pipeCutter_1, pipeCutter_2, screwdriver, saw };
            

        }
    }
}
