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
            PipeCutter pipeCutter_1 = new PipeCutter(true);
            PipeCutter pipeCutter_2 = new PipeCutter(true);
            Screwdriver screwdriver = new Screwdriver();
            Saw saw = new Saw();
            NailGun nailGun = new NailGun();
            WireStripper wireStripper = new WireStripper();
            hammer.Use();

            Tool[] tools = new Tool[] { hammer, pipeCutter_1, pipeCutter_2, screwdriver, saw , nailGun, wireStripper};
            Toolbox toolbox = new Toolbox();
            foreach (Tool tool in tools)
            {
                tool.Describe();
                tool.Use();
                toolbox.AddTool(tool);
            }

            toolbox.printTools();

        }
    }
}
